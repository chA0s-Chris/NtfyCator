// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator;

using NtfyCator.Messages;

/// <summary>
/// Client for publishing notifications using the <c>Ntfy</c> API.
/// </summary>
public interface INotificator
{
    /// <summary>
    /// Target server URI.
    /// </summary>
    Uri ServerUri { get; }

    /// <summary>
    /// Sends a notification to the server.
    /// </summary>
    /// <param name="message">Message to send.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task NotifyAsync(NtfyMessage message, CancellationToken cancellationToken = default);

    /// <summary>
    /// Sets the access token for authentication.
    /// </summary>
    /// <param name="accessToken">The access token.</param>
    /// <returns>The current instance of <see cref="INotificator"/>.</returns>
    INotificator WithAccessToken(String accessToken);

    /// <summary>
    /// Sets the user credentials for authentication.
    /// </summary>
    /// <param name="user">The username.</param>
    /// <param name="password">The password.</param>
    /// <returns>The current instance of <see cref="INotificator"/>.</returns>
    INotificator WithCredentials(String user, String password);
}
