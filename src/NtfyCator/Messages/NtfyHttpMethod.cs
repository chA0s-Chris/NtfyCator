// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Messages;

using System.Text.Json.Serialization;

/// <summary>
/// HTTP methods (verbs) to use with <see cref="NtfyHttpAction"/>.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NtfyHttpMethod
{
    /// <summary>
    /// Represents the HTTP GET method.
    /// </summary>
    [JsonStringEnumMemberName("GET")]
    Get,

    /// <summary>
    /// Represents the HTTP POST method.
    /// </summary>
    [JsonStringEnumMemberName("POST")]
    Post,

    /// <summary>
    /// Represents the HTTP PUT method.
    /// </summary>
    [JsonStringEnumMemberName("PUT")]
    Put,

    /// <summary>
    /// Represents the HTTP DELETE method.
    /// </summary>
    [JsonStringEnumMemberName("DELETE")]
    Delete,

    /// <summary>
    /// Represents the HTTP PATCH method.
    /// </summary>
    [JsonStringEnumMemberName("PATCH")]
    Patch,

    /// <summary>
    /// Represents the HTTP OPTIONS method.
    /// </summary>
    [JsonStringEnumMemberName("OPTIONS")]
    Options
}
