// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Communications.Exceptions;

using System.Net;

/// <summary>
/// Represents an error that occurs when access to a topic or resource is forbidden.
/// </summary>
public class NtfyForbiddenException : NtfyException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NtfyForbiddenException"/> class with a specified inner exception.
    /// </summary>
    /// <param name="httpRequestException">The exception that is the cause of the current exception.</param>
    internal NtfyForbiddenException(HttpRequestException httpRequestException)
        : base("Access to the topic or resource is forbidden.",
               HttpStatusCode.Forbidden,
               httpRequestException) { }
}
