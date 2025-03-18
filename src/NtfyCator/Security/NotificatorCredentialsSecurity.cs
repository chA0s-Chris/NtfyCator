// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Security;

using System.Text;

public sealed class NotificatorCredentialsSecurity : NotificatorSecurity
{
    private readonly String _credentials;

    public NotificatorCredentialsSecurity(String user, String password)
    {
        if (String.IsNullOrWhiteSpace(user)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(user));
        if (String.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(password));

        _credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{user}:{password}"));
    }

    public override void SecureRequest(HttpRequestMessage request)
    {
        if (request == null) throw new ArgumentNullException(nameof(request));

        request.Headers.Authorization = new("Basic", _credentials);
    }
}
