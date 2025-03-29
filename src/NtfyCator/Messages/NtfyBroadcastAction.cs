// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Messages;

using System.Text.Json.Serialization;

/// <summary>
/// Represents a ntfy broadcast action.
/// </summary>
public sealed class NtfyBroadcastAction : NtfyAction
{
    /// <summary>
    /// Gets the extras for the broadcast action.
    /// </summary>
    [JsonPropertyName("extras")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Dictionary<String, String>? Extras { get; init; }

    /// <summary>
    /// Gets the intent for the broadcast action.
    /// </summary>
    [JsonPropertyName("intent")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public String? Intent { get; init; }

    /// <inheritdoc/>
    public override String Type => "broadcast";

    /// <summary>
    /// Gets the URL for the broadcast action.
    /// </summary>
    [JsonPropertyName("url")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public String? Url { get; init; }
}
