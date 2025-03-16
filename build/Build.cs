// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace BuildPipeline;

using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Components;
using System;
using System.Collections.Generic;

internal class Build : NukeBuild,
                       IHazArtifacts,
                       IHazSolution,
                       IHazGitRepository,
                       ICompile,
                       ITest
{
    public Configure<DotNetBuildSettings> CompileSettings => settings =>
        settings.EnableContinuousIntegrationBuild()
                .EnableTreatWarningsAsErrors();

    public Configuration Configuration => Configuration.Release;

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

    IEnumerable<Project> ITest.TestProjects => Partition.GetCurrent(From<IHazSolution>().Solution.GetAllProjects("*.Tests"));

    public static Int32 Main() => Execute<Build>(x => ((ICompile)x).Compile);

    private T From<T>() where T : INukeBuild => (T)(Object)this;
}
