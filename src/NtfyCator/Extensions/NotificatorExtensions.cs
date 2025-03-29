// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.

// ReSharper disable once CheckNamespace
namespace NtfyCator;

/// <summary>
/// Extension methods for <see cref="INotificator"/>.
/// </summary>
public static class NotificatorExtensions
{
    /// <summary>
    /// Creates a <see cref="NotificationBuilder"/> for sending a notification using the specified topic.
    /// </summary>
    /// <param name="notificator">The notificator instance to extend.</param>
    /// <param name="topic">The topic to notify.</param>
    /// <returns>A <see cref="NotificationBuilder"/> instance.</returns>
    public static NotificationBuilder NotifyTopic(this INotificator notificator, String topic) => new(notificator, topic);
}
