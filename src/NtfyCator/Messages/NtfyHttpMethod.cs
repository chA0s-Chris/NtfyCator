// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Messages;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NtfyHttpMethod
{
    [JsonStringEnumMemberName("GET")]
    Get,

    [JsonStringEnumMemberName("POST")]
    Post,

    [JsonStringEnumMemberName("PUT")]
    Put,

    [JsonStringEnumMemberName("DELETE")]
    Delete,

    [JsonStringEnumMemberName("PATCH")]
    Patch,

    [JsonStringEnumMemberName("OPTIONS")]
    Options
}
