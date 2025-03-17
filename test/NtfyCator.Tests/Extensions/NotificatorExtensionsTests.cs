// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Tests.Extensions;

using FluentAssertions;
using Moq;
using NUnit.Framework;

public class NotificatorExtensionsTests
{
    [Test]
    public void NotifyTopic_ReturnsNotificationBuilder()
    {
        var notificatorMock = new Mock<INotificator>(MockBehavior.Strict);
        var builder = notificatorMock.Object.NotifyTopic("topic");

        builder.Should().BeOfType<NotificationBuilder>();
    }
}
