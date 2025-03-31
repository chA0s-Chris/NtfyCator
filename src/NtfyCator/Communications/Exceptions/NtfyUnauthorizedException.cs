// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Communications.Exceptions;

using System.Net;

/// <summary>
/// Represents an error that occurs when the user is not authorized to send a notification.
/// </summary>
public class NtfyUnauthorizedException : NtfyException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NtfyUnauthorizedException"/> class with a specified inner exception.
    /// </summary>
    /// <param name="httpRequestException">The exception that is the cause of the current exception.</param>
    internal NtfyUnauthorizedException(HttpRequestException httpRequestException)
        : base("Not authorized to send notification. Security must be set.",
               HttpStatusCode.Unauthorized,
               httpRequestException) { }
}
