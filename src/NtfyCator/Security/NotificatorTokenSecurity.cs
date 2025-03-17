// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Security;

public sealed class NotificatorTokenSecurity : NotificatorSecurity
{
    private readonly String _accessToken;

    public NotificatorTokenSecurity(String accessToken)
    {
        if (String.IsNullOrWhiteSpace(accessToken)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(accessToken));
        _accessToken = accessToken;
    }

    public override void SecureRequest(HttpRequestMessage request)
    {
        if (request == null) throw new ArgumentNullException(nameof(request));

        request.Headers.Authorization = new("Bearer", _accessToken);
    }
}
