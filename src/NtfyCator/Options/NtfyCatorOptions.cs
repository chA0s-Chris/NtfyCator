// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Options;

using NtfyCator.Resources;

/// <summary>
/// Represents the options for configuring the NtfyCator.
/// </summary>
public class NtfyCatorOptions
{
    /// <summary>
    /// Gets or sets the URI of the server.
    /// </summary>
    /// <remarks>
    /// The default value is <see cref="Defaults.ServerUri"/>.
    /// </remarks>
    public String Uri { get; set; } = Defaults.ServerUri;
}
