// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Messages;

using System.Text.Json.Serialization;

/// <summary>
/// Represents an HTTP action.
/// </summary>
public sealed class NtfyHttpAction : NtfyAction
{
    /// <summary>
    /// Gets the body of the HTTP request.
    /// </summary>
    [JsonPropertyName("body")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public String? Body { get; init; }

    /// <summary>
    /// Gets the headers of the HTTP request.
    /// </summary>
    [JsonPropertyName("headers")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Dictionary<String, String>? Headers { get; init; }

    /// <summary>
    /// Gets the HTTP method.
    /// </summary>
    [JsonPropertyName("method")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public NtfyHttpMethod? Method { get; init; }

    /// <inheritdoc/>
    public override String Type => "http";

    /// <summary>
    /// Gets the URL for the HTTP action.
    /// </summary>
    [JsonPropertyName("url")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public required String Url { get; init; }
}
