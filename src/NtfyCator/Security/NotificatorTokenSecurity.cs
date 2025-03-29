// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Security;

/// <summary>
/// Representation of a token for bearer token authorization.
/// </summary>
public sealed class NotificatorTokenSecurity : NotificatorSecurity
{
    private readonly String _accessToken;

    /// <summary>
    /// Initializes a new instance of the <see cref="NotificatorTokenSecurity"/> class.
    /// </summary>
    /// <param name="accessToken">The access token to use for securing requests.</param>
    /// <exception cref="ArgumentException">Thrown when the access token is <see langword="null"/> or whitespace.</exception>
    public NotificatorTokenSecurity(String accessToken)
    {
        if (String.IsNullOrWhiteSpace(accessToken)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(accessToken));
        _accessToken = accessToken;
    }

    /// <summary>
    /// Secures the specified HTTP request by adding a bearer token authorization header.
    /// </summary>
    /// <param name="request">The HTTP request to secure.</param>
    /// <exception cref="ArgumentNullException">Thrown when the request is <see langword="null"/>.</exception>
    public override void SecureRequest(HttpRequestMessage request)
    {
        if (request == null) throw new ArgumentNullException(nameof(request));

        request.Headers.Authorization = new("Bearer", _accessToken);
    }
}
