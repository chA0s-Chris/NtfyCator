// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Communications.Exceptions;

using System.Net;

/// <summary>
/// Represents errors that occur during NtfyCator communication.
/// </summary>
public class NtfyException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NtfyException"/> class with a specified error message, status code, and an optional inner exception.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="statusCode">The HTTP status code associated with the error.</param>
    /// <param name="httpRequestException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    internal NtfyException(String message, HttpStatusCode? statusCode, HttpRequestException? httpRequestException = null)
        : base(message, httpRequestException)
    {
        StatusCode = statusCode;
    }

    /// <summary>
    /// Gets the HTTP status code associated with the error.
    /// </summary>
    public HttpStatusCode? StatusCode { get; }
}
