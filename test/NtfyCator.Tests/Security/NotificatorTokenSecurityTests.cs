// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Tests.Security;

using FluentAssertions;
using NtfyCator.Security;
using NUnit.Framework;

public class NotificatorTokenSecurityTests
{
    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void Ctor_NullOrWhitespaceAccessToken_ThrowsArgumentException(String? accessToken)
    {
        FluentActions.Invoking(() => new NotificatorTokenSecurity(accessToken!))
                     .Should().ThrowExactly<ArgumentException>();
    }

    [Test]
    public void SecureRequest_NullRequest_ThrowsArgumentNullException()
    {
        var security = new NotificatorTokenSecurity("token");

        FluentActions.Invoking(() => security.SecureRequest(null!))
                     .Should().ThrowExactly<ArgumentNullException>();
    }

    [Test]
    public void SecureRequest_ValidRequest_SetsAuthorizationHeader()
    {
        var token = Guid.NewGuid().ToString();
        var security = new NotificatorTokenSecurity(token);
        var request = new HttpRequestMessage(HttpMethod.Post, "https://ntfy.sh");

        request.Headers.Authorization.Should().BeNull();
        security.SecureRequest(request);
        request.Headers.Authorization.Scheme.Should().Be("Bearer");
        request.Headers.Authorization.Parameter.Should().Be(token);
    }
}
