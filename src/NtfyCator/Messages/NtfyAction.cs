// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Messages;

using System.Text.Json.Serialization;

[JsonPolymorphic(IgnoreUnrecognizedTypeDiscriminators = false)]
[JsonDerivedType(typeof(NtfyViewAction))]
[JsonDerivedType(typeof(NtfyBroadcastAction))]
[JsonDerivedType(typeof(NtfyHttpAction))]
public abstract class NtfyAction
{
    [JsonPropertyName("clear")]
    public Boolean ClearNotification { get; init; }

    [JsonPropertyName("label")]
    public required String Label { get; init; }

    [JsonPropertyName("action")]
    public abstract String Type { get; }
}
