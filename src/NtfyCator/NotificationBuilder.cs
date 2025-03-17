// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator;

using NtfyCator.Messages;

public sealed class NotificationBuilder : NtfyMessageBuilderBase<NotificationBuilder>
{
    private readonly INotificator _notificator;

    public NotificationBuilder(INotificator notificator, String topic) : base(topic)
    {
        _notificator = notificator ?? throw new ArgumentNullException(nameof(notificator));
    }

    public async Task SendAsync(CancellationToken cancellationToken = default)
        => await _notificator.NotifyAsync(Message, cancellationToken);
}
