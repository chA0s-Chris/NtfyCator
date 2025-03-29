// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Security;

using System.Text;

/// <summary>
/// Representation of credentials for basic authentication.
/// </summary>
public sealed class NotificatorCredentialsSecurity : NotificatorSecurity
{
    private readonly String _credentials;

    /// <summary>
    /// Initializes a new instance of the <see cref="NotificatorCredentialsSecurity"/> class.
    /// </summary>
    /// <param name="user">The username for basic authentication.</param>
    /// <param name="password">The password for basic authentication.</param>
    /// <exception cref="ArgumentException">Thrown when the user or password is <see langword="null"/> or whitespace.</exception>
    public NotificatorCredentialsSecurity(String user, String password)
    {
        if (String.IsNullOrWhiteSpace(user)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(user));
        if (String.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(password));

        _credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{user}:{password}"));
    }

    /// <summary>
    /// Secures the specified HTTP request by adding a basic authentication authorization header.
    /// </summary>
    /// <param name="request">The HTTP request to secure.</param>
    /// <exception cref="ArgumentNullException">Thrown when the request is <see langword="null"/>.</exception>
    public override void SecureRequest(HttpRequestMessage request)
    {
        if (request == null) throw new ArgumentNullException(nameof(request));

        request.Headers.Authorization = new("Basic", _credentials);
    }
}
