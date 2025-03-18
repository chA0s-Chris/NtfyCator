// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Tests;

using FluentAssertions;
using Microsoft.Extensions.Options;
using Moq;
using NtfyCator.Communications;
using NtfyCator.Messages;
using NtfyCator.Options;
using NtfyCator.Resources;
using NtfyCator.Security;
using NUnit.Framework;

public class NotificatorTests
{
    [Test]
    public void Ctor_NullNtfyHttpClient_ThrowsArgumentNullException()
    {
        FluentActions.Invoking(() => new Notificator(null!, Mock.Of<IOptions<NtfyCatorOptions>>()))
                     .Should().ThrowExactly<ArgumentNullException>();
    }

    [Test]
    public void Ctor_NullOptions_ThrowsArgumentNullException()
    {
        FluentActions.Invoking(() => new Notificator(Mock.Of<INtfyHttpClient>(), null!))
                     .Should().ThrowExactly<ArgumentNullException>();
    }

    [Test]
    public void Ctor_ValidOptions_SetServerUriFromOptions()
    {
        var uri = "https://myntfy.server.com";

        var optionsMock = new Mock<IOptions<NtfyCatorOptions>>(MockBehavior.Strict);
        optionsMock.Setup(x => x.Value).Returns(new NtfyCatorOptions
        {
            Uri = uri
        });

        var notificator = new Notificator(Mock.Of<INtfyHttpClient>(), optionsMock.Object);
        notificator.ServerUri.Should().Be(uri);

        optionsMock.VerifyAll();
    }

    [Test]
    public async Task NotifyAsync_NullMessage_ThrowsArgumentNullException()
    {
        var optionsMock = new Mock<IOptions<NtfyCatorOptions>>(MockBehavior.Strict);
        optionsMock.Setup(x => x.Value).Returns(new NtfyCatorOptions());

        var notificator = new Notificator(Mock.Of<INtfyHttpClient>(), optionsMock.Object);

        await FluentActions.Invoking(() => notificator.NotifyAsync(null!))
                           .Should().ThrowExactlyAsync<ArgumentNullException>();
    }

    [Test]
    public async Task NotifyAsync_ValidMessage_CallsNtfyHttpClientSendNotificationAsync()
    {
        var message = new NtfyMessage
        {
            Topic = "topic"
        };

        var uri = new Uri(Defaults.ServerUri, UriKind.Absolute);

        var ntfyHttpClientMock = new Mock<INtfyHttpClient>(MockBehavior.Strict);
        ntfyHttpClientMock.Setup(x => x.SendNotificationAsync(uri, message, It.IsAny<CancellationToken>()))
                          .Returns(Task.CompletedTask);

        var optionsMock = new Mock<IOptions<NtfyCatorOptions>>(MockBehavior.Strict);
        optionsMock.Setup(x => x.Value).Returns(new NtfyCatorOptions());

        var notificator = new Notificator(ntfyHttpClientMock.Object, optionsMock.Object);

        await notificator.NotifyAsync(message);

        ntfyHttpClientMock.VerifyAll();
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void WithAccessToken_NullOrWhitespaceAccessToken_ThrowsArgumentException(String? accessToken)
    {
        var optionsMock = new Mock<IOptions<NtfyCatorOptions>>(MockBehavior.Strict);
        optionsMock.Setup(x => x.Value).Returns(new NtfyCatorOptions());

        var notificator = new Notificator(Mock.Of<INtfyHttpClient>(), optionsMock.Object);

        FluentActions.Invoking(() => notificator.WithAccessToken(accessToken!))
                     .Should().ThrowExactly<ArgumentException>();
    }

    [Test]
    public void WithAccessToken_ValidAccessToken_SetsSecurity()
    {
        var token = Guid.NewGuid().ToString();

        var ntfyHttpClientMock = new Mock<INtfyHttpClient>(MockBehavior.Strict);
        ntfyHttpClientMock.Setup(x => x.SetSecurity(It.IsAny<NotificatorSecurity>()))
                          .Callback<NotificatorSecurity>(security =>
                          {
                              security.Should().BeOfType<NotificatorTokenSecurity>();
                          });

        var optionsMock = new Mock<IOptions<NtfyCatorOptions>>(MockBehavior.Strict);
        optionsMock.Setup(x => x.Value).Returns(new NtfyCatorOptions());

        new Notificator(ntfyHttpClientMock.Object, optionsMock.Object)
            .WithAccessToken(token);

        ntfyHttpClientMock.VerifyAll();
        optionsMock.VerifyAll();
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void WithCredentials_NullOrWhitespacePassword_ThrowsArgumentException(String? password)
    {
        var optionsMock = new Mock<IOptions<NtfyCatorOptions>>(MockBehavior.Strict);
        optionsMock.Setup(x => x.Value).Returns(new NtfyCatorOptions());

        var notificator = new Notificator(Mock.Of<INtfyHttpClient>(), optionsMock.Object);

        FluentActions.Invoking(() => notificator.WithCredentials("user", password!))
                     .Should().ThrowExactly<ArgumentException>();
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void WithCredentials_NullOrWhitespaceUser_ThrowsArgumentException(String? user)
    {
        var optionsMock = new Mock<IOptions<NtfyCatorOptions>>(MockBehavior.Strict);
        optionsMock.Setup(x => x.Value).Returns(new NtfyCatorOptions());

        var notificator = new Notificator(Mock.Of<INtfyHttpClient>(), optionsMock.Object);

        FluentActions.Invoking(() => notificator.WithCredentials(user!, "password"))
                     .Should().ThrowExactly<ArgumentException>();
    }

    [Test]
    public void WithCredentials_UserAndPassword_SetsSecurity()
    {
        var ntfyHttpClientMock = new Mock<INtfyHttpClient>(MockBehavior.Strict);
        ntfyHttpClientMock.Setup(x => x.SetSecurity(It.IsAny<NotificatorSecurity>()))
                          .Callback<NotificatorSecurity>(security =>
                          {
                              security.Should().BeOfType<NotificatorCredentialsSecurity>();
                          });

        var optionsMock = new Mock<IOptions<NtfyCatorOptions>>(MockBehavior.Strict);
        optionsMock.Setup(x => x.Value).Returns(new NtfyCatorOptions());

        new Notificator(ntfyHttpClientMock.Object, optionsMock.Object)
            .WithCredentials("user", "password");

        ntfyHttpClientMock.VerifyAll();
        optionsMock.VerifyAll();
    }
}
