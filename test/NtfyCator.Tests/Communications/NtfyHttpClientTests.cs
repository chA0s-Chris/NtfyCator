// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Tests.Communications;

using FluentAssertions;
using Moq;
using Moq.Protected;
using NtfyCator.Communications;
using NtfyCator.Messages;
using NtfyCator.Resources;
using NtfyCator.Security;
using NUnit.Framework;
using System.Net;

public class NtfyHttpClientTests
{
    private Mock<HttpMessageHandler> _httpMessageHandlerMock;
    private NtfyHttpClient _ntfyHttpClient;

    [Test]
    public async Task SendNotificationAsync_SecuritySet_CallsSecureRequest()
    {
        _httpMessageHandlerMock.Protected()
                               .Setup<Task<HttpResponseMessage>>(
                                   "SendAsync",
                                   ItExpr.IsAny<HttpRequestMessage>(),
                                   ItExpr.IsAny<CancellationToken>())
                               .ReturnsAsync(new HttpResponseMessage(HttpStatusCode.OK));

        var securityMock = new Mock<NotificatorSecurity>(MockBehavior.Strict);
        securityMock.Setup(s => s.SecureRequest(It.IsAny<HttpRequestMessage>()));

        _ntfyHttpClient.SetSecurity(securityMock.Object);

        var message = new NtfyMessage
        {
            Topic = "myTopic"
        };
        await _ntfyHttpClient.SendNotificationAsync(new(Defaults.ServerUri, UriKind.Absolute), message, CancellationToken.None);

        securityMock.VerifyAll();
    }

    [Test]
    public void SetSecurity_CalledTwice_ThrowsInvalidOperationException()
    {
        _ntfyHttpClient.SetSecurity(new NotificatorTokenSecurity("token"));
        FluentActions.Invoking(() => _ntfyHttpClient.SetSecurity(new NotificatorTokenSecurity("token")))
                     .Should().ThrowExactly<InvalidOperationException>()
                     .WithMessage("Security has already been set.");
    }

    [SetUp]
    public void Setup()
    {
        _httpMessageHandlerMock = new(MockBehavior.Strict);
        var httpClient = new HttpClient(_httpMessageHandlerMock.Object);
        _ntfyHttpClient = new(httpClient);
    }
}
