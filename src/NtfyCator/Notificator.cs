// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator;

using Microsoft.Extensions.Options;
using NtfyCator.Communications;
using NtfyCator.Messages;
using NtfyCator.Options;
using NtfyCator.Security;

internal sealed class Notificator : INotificator
{
    private readonly INtfyHttpClient _httpClient;

    public Notificator(INtfyHttpClient httpClient, IOptions<NtfyCatorOptions> options)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        if (options == null) throw new ArgumentNullException(nameof(options));

        ServerUri = new(options.Value.Uri, UriKind.Absolute);
    }

    public Uri ServerUri { get; }

    public async Task NotifyAsync(NtfyMessage message, CancellationToken cancellationToken = default)
    {
        if (message == null) throw new ArgumentNullException(nameof(message));

        await _httpClient.SendNotificationAsync(ServerUri, message, cancellationToken);
    }

    public INotificator WithAccessToken(String accessToken)
    {
        if (String.IsNullOrWhiteSpace(accessToken)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(accessToken));

        _httpClient.SetSecurity(new NotificatorTokenSecurity(accessToken));
        return this;
    }
}
