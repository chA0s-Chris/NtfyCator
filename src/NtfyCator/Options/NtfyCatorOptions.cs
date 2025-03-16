// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Options;

using NtfyCator.Resources;

public class NtfyCatorOptions
{
    public const String SectionName = "NtfyCator";

    public String Uri { get; set; } = Defaults.ServerUri;
}
