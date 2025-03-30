// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace BuildPipeline;

using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Utilities.Collections;
using Nuke.Components;
using System;
using System.Collections.Generic;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

internal class Build : NukeBuild,
                       IHazArtifacts,
                       IHazSolution,
                       IHazGitRepository,
                       ICompile,
                       ITest,
                       IPack
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

    private static AbsolutePath TestsDirectory => RootDirectory / "tests";

    private Target Clean => target =>
        target.Before<IRestore>()
              .Executes(() =>
              {
                  SourceDirectory.GlobDirectories("**/bin", "**/obj").DeleteDirectories();
                  TestsDirectory.GlobDirectories("**/bin", "**/obj").DeleteDirectories();

                  ((IHazArtifacts)this).ArtifactsDirectory.CreateOrCleanDirectory();
              });

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

    IEnumerable<Project> ITest.TestProjects => Partition.GetCurrent(From<IHazSolution>().Solution.GetAllProjects("*.Tests"));

    public static Int32 Main() => Execute<Build>(x => ((ICompile)x).Compile);

    private T From<T>() where T : INukeBuild => (T)(Object)this;
}
