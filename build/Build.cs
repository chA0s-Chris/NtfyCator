// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace BuildPipeline;

using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.ReportGenerator;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;
using Nuke.Components;
using Serilog;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.Json;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

internal class Build : NukeBuild,
                       IHazArtifacts,
                       IHazSolution,
                       IHazGitRepository,
                       ICompile,
                       ITest,
                       IPack,
                       IPublish,
                       IReportCoverage
{
    public Configure<DotNetBuildSettings> CompileSettings => settings =>
        settings.EnableContinuousIntegrationBuild()
                .EnableTreatWarningsAsErrors();

    public Configuration Configuration => Configuration.Release;

    public Configure<DotNetPublishSettings> PublishSettings => settings =>
        settings.EnableContinuousIntegrationBuild();

    public Configure<DotNetPackSettings> PackSettings => settings =>
        settings.DisablePackageRequireLicenseAcceptance()
                .EnableContinuousIntegrationBuild()
                .ResetNoBuild()
                .SetProject("src/NtfyCator/NtfyCator.csproj")
                .AddProperty("AdditionalConstants", "NUGET_RELEASE")
                .AddProperty("SignAssembly", "true")
                .AddProperty("AssemblyOriginatorKeyFile", "../../NtfyCator.snk")
                .EnableIncludeSymbols()
                .SetSymbolPackageFormat(DotNetSymbolPackageFormat.snupkg);

    public Configure<DotNetNuGetPushSettings> PushSettings => settings =>
        settings.EnableSkipDuplicate();

    public Target ReportCoverage => target =>
        target.Inherit<IReportCoverage>()
              .Executes(() =>
              {
                  var coverage = "unknown";

                  try
                  {
                      var json = File.ReadAllText(CoverageSummary);
                      using var jsonDocument = JsonDocument.Parse(json);

                      if (jsonDocument.RootElement.TryGetProperty("summary", out var summary) &&
                          summary.TryGetProperty("linecoverage", out var lineCoverage))
                      {
                          coverage = $"{lineCoverage.GetDouble().ToString("#.0", CultureInfo.InvariantCulture)}%";
                      }
                  }
                  catch (Exception e)
                  {
                      Log.Error(e, "Failed to read coverage summary.");
                  }

                  ReportSummary(config => config.AddPair("Coverage", coverage));
              });

    public Configure<ReportGeneratorSettings> ReportGeneratorSettings => settings =>
        settings.SetReports(From<IReportCoverage>().TestResultDirectory / "**/coverage.cobertura.xml")
                .SetReportTypes(ReportTypes.JsonSummary);

    public Configure<DotNetTestSettings> TestSettings => settings =>
        settings.EnableNoBuild()
                .When(InvokedTargets.Contains(((IReportCoverage)this).ReportCoverage), transform =>
                          transform.SetDataCollector("XPlat Code Coverage")
                                   .SetSettingsFile("coverlet.xml"));

    private static AbsolutePath TestsDirectory => RootDirectory / "tests";

    private Target Clean => target =>
        target.Before<IRestore>()
              .Executes(() =>
              {
                  SourceDirectory.GlobDirectories("**/bin", "**/obj").DeleteDirectories();
                  TestsDirectory.GlobDirectories("**/bin", "**/obj").DeleteDirectories();

                  ((IHazArtifacts)this).ArtifactsDirectory.CreateOrCleanDirectory();
              });

    private AbsolutePath CoverageSummary => From<IReportCoverage>().CoverageReportDirectory / "Summary.json";

    private AbsolutePath SourceDirectory => RootDirectory / "src";

    Target IPack.Pack => target =>
        target.Produces(From<IPack>().PackagesDirectory / "*.nupkg")
              .Executes(() =>
              {
                  DotNetPack(_ => _
                                  .Apply(From<IPack>().PackSettingsBase)
                                  .Apply(PackSettings));

                  ReportSummary(_ => _
                                    .AddPair("Packages", From<IPack>().PackagesDirectory.GlobFiles("*.nupkg").Count.ToString()));
              });

    Target IPublish.Publish => target =>
        target.DependsOn(From<IPack>().Pack)
              .Requires(() => From<IPublish>().NuGetApiKey)
              .Executes(() =>
              {
                  DotNetNuGetPush(_ => _
                                       .Apply(From<IPublish>().PushSettingsBase)
                                       .Apply(PushSettings)
                                       .CombineWith(From<IPublish>().PushPackageFiles, (_, v) => _
                                                        .SetTargetPath(v))
                                       .Apply(From<IPublish>().PackagePushSettings),
                                  From<IPublish>().PushDegreeOfParallelism,
                                  From<IPublish>().PushCompleteOnFailure);
              });

    Boolean IReportCoverage.CreateCoverageHtmlReport => true;

    Boolean IReportCoverage.ReportToCodecov => false;

    IEnumerable<Project> ITest.TestProjects => Partition.GetCurrent(From<IHazSolution>().Solution.GetAllProjects("*.Tests"));

    public static Int32 Main() => Execute<Build>(x => ((ICompile)x).Compile);

    private T From<T>() where T : INukeBuild => (T)(Object)this;
}
