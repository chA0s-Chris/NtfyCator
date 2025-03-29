// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Messages;

using System.Text.Json.Serialization;

/// <summary>
/// Represents a ntfy view action.
/// </summary>
public sealed class NtfyViewAction : NtfyAction
{
    /// <inheritdoc/>
    public override String Type => "view";

    /// <summary>
    /// Gets the URL for the view action.
    /// </summary>
    [JsonPropertyName("url")]
    public required String Url { get; init; }
}
