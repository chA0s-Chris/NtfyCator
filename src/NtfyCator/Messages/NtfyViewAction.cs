// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Messages;

using System.Text.Json.Serialization;

public sealed class NtfyViewAction : NtfyAction
{
    public override String Type => "view";

    [JsonPropertyName("url")]
    public required String Url { get; init; }
}
