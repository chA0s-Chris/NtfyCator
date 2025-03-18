// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Tests.Security;

using FluentAssertions;
using NtfyCator.Security;
using NUnit.Framework;
using System.Text;

public class NotificatorCredentialsSecurityTests
{
    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void Ctor_NullOrWhitespacePassword_ThrowsArgumentException(String? password)
    {
        FluentActions.Invoking(() => new NotificatorCredentialsSecurity("user", password!))
                     .Should().ThrowExactly<ArgumentException>();
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void Ctor_NullOrWhitespaceUser_ThrowsArgumentException(String? user)
    {
        FluentActions.Invoking(() => new NotificatorCredentialsSecurity(user!, "password"))
                     .Should().ThrowExactly<ArgumentException>();
    }

    [Test]
    public void SecureRequest_NullRequest_ThrowsArgumentNullException()
    {
        var security = new NotificatorCredentialsSecurity("user", "password");

        FluentActions.Invoking(() => security.SecureRequest(null!))
                     .Should().ThrowExactly<ArgumentNullException>();
    }

    [Test]
    public void SecureRequest_ValidRequest_SetsAuthorizationHeader()
    {
        var user = "user";
        var password = "password";

        var security = new NotificatorCredentialsSecurity(user, password);
        var request = new HttpRequestMessage(HttpMethod.Post, "https://ntfy.sh");

        request.Headers.Authorization.Should().BeNull();
        security.SecureRequest(request);
        request.Headers.Authorization.Scheme.Should().Be("Basic");
        request.Headers.Authorization.Parameter.Should().Be(Convert.ToBase64String(Encoding.UTF8.GetBytes($"{user}:{password}")));
    }
}
