// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator;

using NtfyCator.Messages;

/// <summary>
/// Build a notification and send it using the specified notificator.
/// </summary>
public sealed class NotificationBuilder : NtfyMessageBuilderBase<NotificationBuilder>
{
    private readonly INotificator _notificator;

    /// <summary>
    /// Initializes a new instance of the <see cref="NotificationBuilder"/> class.
    /// </summary>
    /// <param name="notificator">The notificator to use for sending notifications.</param>
    /// <param name="topic">The topic of the notification.</param>
    /// <exception cref="ArgumentNullException">Thrown when the notificator is null.</exception>
    public NotificationBuilder(INotificator notificator, String topic) : base(topic)
    {
        _notificator = notificator ?? throw new ArgumentNullException(nameof(notificator));
    }

    /// <summary>
    /// Sends the notification asynchronously.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous send operation.</returns>
    public async Task SendAsync(CancellationToken cancellationToken = default)
        => await _notificator.NotifyAsync(Message, cancellationToken);
}
