// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Tests.Messages;

using FluentAssertions;
using NtfyCator.Messages;
using NUnit.Framework;
using System.ComponentModel;

public class NtfyMessageBuilderTests
{
    private static readonly List<Emoji> _emojis = [Emoji.Zzz, Emoji.Rocket, Emoji.FaceWithHeadBandage];
    private static readonly List<String> _emojisAsStrings = ["zzz", "rocket", "face_with_head_bandage"];
    private static readonly List<String> _tags = ["tag1", "tag2"];
    private readonly String _body = "This is **just** a _Test_!";
    private readonly String _delay = "30m";
    private readonly String _email = "none@of.your.biz";
    private readonly String _file = "my.file.dat";
    private readonly Uri _fileUri = new("https://my.file.com/file.dat");
    private readonly NtfyPriority _priority = NtfyPriority.High;
    private readonly String _title = "title";
    private readonly String _topic = "topic";

    [Test]
    public void Build_ReturnsCorrectNtfyMessage()
    {
        var message = new NtfyMessageBuilder(_topic)
                      .WithTitle(_title)
                      .WithPriority(_priority)
                      .WithTags(_tags)
                      .WithMarkdownBody(_body)
                      .Build();

        message.Body.Should().Be(_body);
        message.Priority.Should().Be(_priority);
        message.Tags.Should().BeEquivalentTo(_tags);
        message.Title.Should().Be(_title);
        message.Topic.Should().Be(_topic);
        message.UseMarkdown.Should().BeTrue();
    }

    [Test]
    public void Build_WithEmojis_ReturnsCorrectNtfyMessage()
    {
        var message = new NtfyMessageBuilder(_topic)
                      .WithTags(_emojis)
                      .Build();

        message.Tags.Should().BeEquivalentTo(_emojisAsStrings);
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void Ctor_NullOrWhitespaceTopic_ThrowsArgumentException(String? topic)
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(topic!))
                     .Should().ThrowExactly<ArgumentException>();
    }

    [Test]
    public void ExplicitNtfyMessage_ShouldConvertToNtfyMessage()
    {
        var builder = new NtfyMessageBuilder(_topic);

        var message = (NtfyMessage)builder;
        message.Topic.Should().Be(_topic);
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void WithAttachment_NullOrWhitespaceUri_ThrowsArgumentException(String? uri)
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(_topic).WithAttachment(uri!))
                     .Should().ThrowExactly<ArgumentException>();
    }

    [Test]
    public void WithAttachment_NullUri_ThrowsArgumentNullException()
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(_topic).WithAttachment((Uri)null!))
                     .Should().ThrowExactly<ArgumentNullException>();
    }

    [Test]
    public void WithAttachment_ValidUriAndName_SetsAttachmentAndAttachmentName()
    {
        var message = new NtfyMessageBuilder(_topic)
                      .WithAttachment(_fileUri, _file)
                      .Build();

        message.AttachmentUri.Should().Be(_fileUri);
        message.AttachmentName.Should().Be(_file);
    }

    [Test]
    public void WithAttachment_ValidUriString_SetsAttachment()
    {
        var message = new NtfyMessageBuilder(_topic)
                      .WithAttachment(_fileUri.ToString())
                      .Build();

        message.AttachmentUri.Should().Be(_fileUri);
        message.AttachmentName.Should().BeNull();
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void WithBody_NullOrWhitespaceBody_ThrowsArgumentException(String? body)
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(_topic).WithBody(body!))
                     .Should().ThrowExactly<ArgumentException>();
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase("   ")]
    public void WithClickUri_NullOrWhitespaceUri_ThrowsArgumentException(String? uri)
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(_topic).WithClickUri(uri!))
                     .Should().ThrowExactly<ArgumentException>();
    }

    [Test]
    public void WithClickUri_NullUri_ThrowsArgumentNullException()
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(_topic).WithClickUri((Uri)null!))
                     .Should().ThrowExactly<ArgumentNullException>();
    }

    [Test]
    public void WithClickUri_ValidUri_SetsClickUri()
    {
        var message = new NtfyMessageBuilder(_topic)
                      .WithClickUri(_fileUri)
                      .Build();

        message.ClickUri.Should().Be(_fileUri);
    }

    [Test]
    public void WithClickUri_ValidUriString_SetsClickUri()
    {
        var message = new NtfyMessageBuilder(_topic)
                      .WithClickUri(_fileUri.ToString())
                      .Build();

        message.ClickUri.Should().Be(_fileUri);
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void WithEmail_NullOrWhitespaceEmail_ThrowsArgumentException(String? email)
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(_topic).WithEmail(email!))
                     .Should().ThrowExactly<ArgumentException>();
    }

    [Test]
    public void WithEmail_ValidEmail_SetsEmail()
    {
        var message = new NtfyMessageBuilder(_topic)
                      .WithEmail(_email)
                      .Build();

        message.Email.Should().Be(_email);
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase("   ")]
    public void WithIconUri_NullOrWhitespaceUri_ThrowsArgumentException(String? uri)
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(_topic).WithIconUri(uri!))
                     .Should().ThrowExactly<ArgumentException>();
    }

    [Test]
    public void WithIconUri_NullUri_ThrowsArgumentNullException()
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(_topic).WithIconUri((Uri)null!))
                     .Should().ThrowExactly<ArgumentNullException>();
    }

    [Test]
    public void WithIconUri_ValidUri_SetsClickUri()
    {
        var message = new NtfyMessageBuilder(_topic)
                      .WithIconUri(_fileUri)
                      .Build();

        message.IconUri.Should().Be(_fileUri);
    }

    [Test]
    public void WithIconUri_ValidUriString_SetsClickUri()
    {
        var message = new NtfyMessageBuilder(_topic)
                      .WithIconUri(_fileUri.ToString())
                      .Build();

        message.IconUri.Should().Be(_fileUri);
    }

    [TestCase("12345678")]
    [TestCase("++12345678901")]
    [TestCase("+1(415)555-1212")]
    public void WithPhoneNumber_InvalidPhoneNumber_ThrowsArgumentException(String phoneNumber)
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(_topic).WithPhoneNumber(phoneNumber))
                     .Should().ThrowExactly<ArgumentException>()
                     .WithMessage("Phone number must start *");
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void WithPhoneNumber_NullOrWhitespacePhoneNumber_ThrowsArgumentException(String? phoneNumber)
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(_topic).WithPhoneNumber(phoneNumber!))
                     .Should().ThrowExactly<ArgumentException>();
    }

    [TestCase("+12345678901")]
    [TestCase("+442071838750")]
    [TestCase("+918527663529")]
    public void WithPhoneNumber_ValidPhoneNumber_SetsPhoneNumber(String phoneNumber)
    {
        var message = new NtfyMessageBuilder(_topic)
                      .WithPhoneNumber(phoneNumber)
                      .Build();

        message.PhoneNumber.Should().Be(phoneNumber);
    }

    [TestCase((NtfyPriority)100)]
    [TestCase((NtfyPriority)0)]
    [TestCase((NtfyPriority)1323)]
    public void WithPriority_InvalidPriority_ThrowsArgumentException(NtfyPriority priority)
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(_topic).WithPriority(priority))
                     .Should().ThrowExactly<InvalidEnumArgumentException>();
    }

    [Test]
    public void WithScheduledDelivery_NonNullOrWhitespaceDelay_SetsDelay()
    {
        var message = new NtfyMessageBuilder(_topic)
                      .WithScheduledDelivery(_delay)
                      .Build();

        message.Delay.Should().Be(_delay);
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase("   ")]
    public void WithScheduledDelivery_NullOrWhitespaceDelay_ThrowsArgumentException(String? delay)
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(_topic).WithScheduledDelivery(delay!))
                     .Should().ThrowExactly<ArgumentException>();
    }

    [Test]
    public void WithTag_Called3TimesWithEmojis_SetsAllTags()
    {
        var message = new NtfyMessageBuilder(_topic)
                      .WithTag(_emojis[0])
                      .WithTag(_emojis[1])
                      .WithTag(_emojis[2])
                      .Build();

        message.Tags.Should().BeEquivalentTo(_emojisAsStrings);
    }

    [Test]
    public void WithTag_CalledTwice_SetsBothTags()
    {
        var message = new NtfyMessageBuilder(_topic)
                      .WithTag(_tags[0])
                      .WithTag(_tags[1])
                      .Build();

        message.Tags.Should().BeEquivalentTo(_tags);
    }

    [TestCase((Emoji)10000)]
    [TestCase((Emoji)Int32.MaxValue)]
    public void WithTag_InvalidEmoji_ThrowsInvalidEnumArgumentException(Emoji emoji)
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(_topic).WithTag(emoji))
                     .Should().ThrowExactly<InvalidEnumArgumentException>();
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void WithTag_NullOrWhitespaceTag_ThrowsArgumentException(String? tag)
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(_topic).WithTag(tag!))
                     .Should().ThrowExactly<ArgumentException>();
    }

    [Test]
    public void WithTags_EmptyEmojis_ThrowsArgumentException()
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(_topic).WithTags(Array.Empty<Emoji>()))
                     .Should().ThrowExactly<ArgumentException>();
    }


    [Test]
    public void WithTags_EmptyTags_ThrowsArgumentException()
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(_topic).WithTags(Array.Empty<String>()))
                     .Should().ThrowExactly<ArgumentException>();
    }

    [Test]
    public void WithTags_NullEmojis_ThrowsArgumentNullException()
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(_topic).WithTags((Emoji[])null!))
                     .Should().ThrowExactly<ArgumentNullException>();
    }

    [Test]
    public void WithTags_NullTags_ThrowsArgumentNullException()
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(_topic).WithTags((String[])null!))
                     .Should().ThrowExactly<ArgumentNullException>();
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void WithTitle_NullOrWhitespaceTitle_ThrowsArgumentException(String? title)
    {
        FluentActions.Invoking(() => new NtfyMessageBuilder(_topic).WithTitle(title!))
                     .Should().ThrowExactly<ArgumentException>();
    }

    [Test]
    public void WithVerifiedPhoneNumber_SetsYesAsPhoneNumber()
    {
        var message = new NtfyMessageBuilder(_topic)
                      .WithVerifiedPhoneNumber()
                      .Build();

        message.PhoneNumber.Should().Be("yes");
    }
}
