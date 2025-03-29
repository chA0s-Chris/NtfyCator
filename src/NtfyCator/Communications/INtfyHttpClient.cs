// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Communications;

using NtfyCator.Messages;
using NtfyCator.Security;

/// <summary>
/// HTTP client that transports notifications.
/// </summary>
public interface INtfyHttpClient
{
    /// <summary>
    /// Sends a notification asynchronously.
    /// </summary>
    /// <param name="endpoint">The endpoint to send the notification to.</param>
    /// <param name="message">The notification message to send.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task SendNotificationAsync(Uri endpoint, NtfyMessage message, CancellationToken cancellationToken = default);

    /// <summary>
    /// Secures the HTTP client using an implementation of <see cref="NotificatorSecurity"/>.
    /// </summary>
    /// <param name="security">The notificator security to set.</param>
    /// <exception cref="InvalidOperationException">Thrown if security was already set.</exception>
    void SetSecurity(NotificatorSecurity security);
}
