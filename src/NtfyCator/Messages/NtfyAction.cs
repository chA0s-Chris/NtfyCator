// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Messages;

using System.Text.Json.Serialization;

/// <summary>
/// Represents an abstract base class for different types of actions.
/// </summary>
[JsonPolymorphic(IgnoreUnrecognizedTypeDiscriminators = false)]
[JsonDerivedType(typeof(NtfyViewAction))]
[JsonDerivedType(typeof(NtfyBroadcastAction))]
[JsonDerivedType(typeof(NtfyHttpAction))]
public abstract class NtfyAction
{
    /// <summary>
    /// Gets a value indicating whether the notification should be cleared.
    /// </summary>
    [JsonPropertyName("clear")]
    public Boolean ClearNotification { get; init; }

    /// <summary>
    /// Gets the label of the action.
    /// </summary>
    [JsonPropertyName("label")]
    public required String Label { get; init; }

    /// <summary>
    /// Gets the type of the action.
    /// </summary>
    [JsonPropertyName("action")]
    public abstract String Type { get; }
}

