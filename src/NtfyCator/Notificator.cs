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
    private readonly NtfyCatorOptions _options;
    private NotificatorSecurity _security = new DisabledNotificatorSecurity();

    public Notificator(INtfyHttpClient httpClient, IOptions<NtfyCatorOptions> options)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        _options = options.Value ?? throw new ArgumentException("Value cannot be null.", nameof(options));

        ServerUri = new(_options.Uri, UriKind.Absolute);
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
