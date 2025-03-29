// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Security;

/// <summary>
/// Abstract base class for securing HTTP requests.
/// </summary>
public abstract class NotificatorSecurity
{
    /// <summary>
    /// Secures the specified HTTP request.
    /// </summary>
    /// <param name="request">The HTTP request to secure.</param>
    public abstract void SecureRequest(HttpRequestMessage request);
}
