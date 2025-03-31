// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Communications.Exceptions;

using System.Net;

/// <summary>
/// Represents an error that occurs when the rate limit is reached.
/// </summary>
public class NtfyRateLimitReachedException : NtfyException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NtfyRateLimitReachedException"/> class with a specified inner exception.
    /// </summary>
    /// <param name="httpRequestException">The exception that is the cause of the current exception.</param>
    internal NtfyRateLimitReachedException(HttpRequestException? httpRequestException)
        : base("Rate limit reached.",
#if NETSTANDARD2_0
               null,
#else
               HttpStatusCode.TooManyRequests,
#endif
               httpRequestException) { }
}
