// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Tests.Messages;

using FluentAssertions;
using NtfyCator.Messages;
using NUnit.Framework;
using System.ComponentModel;

public class EmojiHelperTests
{
    [TestCase((Emoji)10000)]
    [TestCase((Emoji)Int32.MaxValue)]
    public void GetEmojiValue_InvalidEmoji_ThrowsInvalidEnumArgumentException(Emoji emoji)
    {
        FluentActions.Invoking(() => EmojiHelper.GetEmojiValue(emoji))
                     .Should().ThrowExactly<InvalidEnumArgumentException>();
    }

    [TestCase(Emoji.MusicalNote, "musical_note")]
    [TestCase(Emoji.Heart, "heart")]
    [TestCase(Emoji.SmilingFaceWithThreeHearts, "smiling_face_with_three_hearts")]
    public void GetEmojiValue_ValidEmoji_ReturnsEmojiValue(Emoji emoji, String expectedValue)
    {
        var actualValue = EmojiHelper.GetEmojiValue(emoji);
        actualValue.Should().Be(expectedValue);
    }
}
