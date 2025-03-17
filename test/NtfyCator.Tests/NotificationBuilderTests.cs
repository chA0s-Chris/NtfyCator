// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Tests;

using FluentAssertions;
using Moq;
using NtfyCator.Messages;
using NUnit.Framework;

public class NotificationBuilderTests
{
    [Test]
    public void Ctor_NullNotificator_ThrowsArgumentNullException()
    {
        FluentActions.Invoking(() => new NotificationBuilder(null!, "topic"))
                     .Should().ThrowExactly<ArgumentNullException>();
    }

    [Test]
    public async Task SendAsync_CallsNotificatorNotifyAsync()
    {
        var notificatorMock = new Mock<INotificator>(MockBehavior.Strict);
        notificatorMock.Setup(x => x.NotifyAsync(It.IsAny<NtfyMessage>(), It.IsAny<CancellationToken>()))
                       .Returns(Task.CompletedTask);

        await new NotificationBuilder(notificatorMock.Object, "topic").SendAsync();

        notificatorMock.VerifyAll();
    }
}
