// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Communications;

using NtfyCator.Communications.Exceptions;
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
    /// <exception cref="NtfyUnauthorizedException">Thrown when the user is not authorized to send a notification.</exception>
    /// <exception cref="NtfyForbiddenException">Thrown when access to the topic or resource is forbidden.</exception>
    /// <exception cref="NtfyNotFoundException">Thrown when the topic or resource is not found.</exception>
    /// <exception cref="NtfyTooLargeException">Thrown when the notification is too large.</exception>
    /// <exception cref="NtfyRateLimitReachedException">Thrown when the rate limit is reached.</exception>
    /// <exception cref="NtfyException">Thrown when an error occurs while sending the notification.</exception>
    Task SendNotificationAsync(Uri endpoint, NtfyMessage message, CancellationToken cancellationToken = default);

    /// <summary>
    /// Secures the HTTP client using an implementation of <see cref="NotificatorSecurity"/>.
    /// </summary>
    /// <param name="security">The notificator security to set.</param>
    /// <exception cref="InvalidOperationException">Thrown if security was already set.</exception>
    void SetSecurity(NotificatorSecurity security);
}
