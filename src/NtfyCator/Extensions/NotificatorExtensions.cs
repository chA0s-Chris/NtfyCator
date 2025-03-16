// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.

// ReSharper disable once CheckNamespace
namespace NtfyCator;

public static class NotificatorExtensions
{
    public static NotificationBuilder NotifyTopic(this INotificator notificator, String topic) => new(notificator, topic);
}
