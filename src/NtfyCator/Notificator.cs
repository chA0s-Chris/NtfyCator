// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator;

using Microsoft.Extensions.Options;
using NtfyCator.Communications;
using NtfyCator.Messages;
using NtfyCator.Options;
using NtfyCator.Security;

/// <summary>
/// Represents the base implementation of a notificator.
/// </summary>
internal sealed class Notificator : INotificator
{
    private readonly INtfyHttpClient _httpClient;

    /// <summary>
    /// Initializes a new instance of the <see cref="Notificator"/> class.
    /// </summary>
    /// <param name="httpClient">The HTTP client to use for sending notifications.</param>
    /// <param name="options">The options for configuring the notificator.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="httpClient"/> or <paramref name="options"/> is <see langword="null"/>.
    /// </exception>
    public Notificator(INtfyHttpClient httpClient, IOptions<NtfyCatorOptions> options)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        if (options == null) throw new ArgumentNullException(nameof(options));

        ServerUri = new(options.Value.Uri, UriKind.Absolute);
    }

    /// <inheritdoc/>
    public Uri ServerUri { get; }

    /// <inheritdoc/>
    public async Task NotifyAsync(NtfyMessage message, CancellationToken cancellationToken = default)
    {
        if (message == null) throw new ArgumentNullException(nameof(message));

        await _httpClient.SendNotificationAsync(ServerUri, message, cancellationToken);
    }

    /// <inheritdoc/>
    public INotificator WithAccessToken(String accessToken)
    {
        if (String.IsNullOrWhiteSpace(accessToken)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(accessToken));

        _httpClient.SetSecurity(new NotificatorTokenSecurity(accessToken));
        return this;
    }

    /// <inheritdoc/>
    public INotificator WithCredentials(String user, String password)
    {
        if (String.IsNullOrWhiteSpace(user)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(user));
        if (String.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(password));

        _httpClient.SetSecurity(new NotificatorCredentialsSecurity(user, password));
        return this;
    }
}
