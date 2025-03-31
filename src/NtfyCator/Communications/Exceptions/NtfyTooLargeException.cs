// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Communications.Exceptions;

using System.Net;

/// <summary>
/// Represents an error that occurs when a notification is too large.
/// </summary>
public class NtfyTooLargeException : NtfyException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NtfyTooLargeException"/> class with a specified inner exception.
    /// </summary>
    /// <param name="httpRequestException">The exception that is the cause of the current exception.</param>
    public NtfyTooLargeException(HttpRequestException httpRequestException)
        : base("Notification too large. The server did not accept the notification.",
               HttpStatusCode.RequestEntityTooLarge,
               httpRequestException) { }
}
