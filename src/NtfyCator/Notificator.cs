// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator;

using NtfyCator.Messages;
using NtfyCator.Security;

internal sealed class Notificator : INotificator
{
    private readonly HttpClient _httpClient;
    private NotificatorSecurity _security = new DisabledNotificatorSecurity();

    public Notificator(Uri serverUri, HttpClient httpClient)
    {
        ServerUri = serverUri ?? throw new ArgumentNullException(nameof(serverUri));
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

        if (!ServerUri.IsAbsoluteUri)
            throw new ArgumentException("Value must be an absolute URI.", nameof(serverUri));
    }

    public Uri ServerUri { get; }

    internal void ThrowIfSecurityIsSet()
    {
        if (_security is NotificatorTokenSecurity)
            throw new InvalidOperationException("Access token is already set.");
    }

    public Task NotifyAsync(NtfyMessage message, CancellationToken cancellationToken = default) => throw new NotImplementedException();

    public INotificator WithAccessToken(String accessToken)
    {
        if (String.IsNullOrWhiteSpace(accessToken)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(accessToken));
        ThrowIfSecurityIsSet();

        _security = new NotificatorTokenSecurity(accessToken);
        return this;
    }
}
