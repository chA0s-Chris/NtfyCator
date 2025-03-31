// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Communications.Exceptions;

using System.Net;

/// <summary>
/// Represents an error that occurs when a topic or resource is not found.
/// </summary>
public class NtfyNotFoundException : NtfyException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NtfyNotFoundException"/> class with a specified inner exception.
    /// </summary>
    /// <param name="httpRequestException">The exception that is the cause of the current exception.</param>
    internal NtfyNotFoundException(HttpRequestException httpRequestException)
        : base("Topic or resource not found.",
               HttpStatusCode.NotFound,
               httpRequestException) { }
}
