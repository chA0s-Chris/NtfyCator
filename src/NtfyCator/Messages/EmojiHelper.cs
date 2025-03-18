// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Messages;

using System.ComponentModel;
using System.Runtime.Serialization;

internal static class EmojiHelper
{
    public static String GetEmojiValue(Emoji emoji)
    {
        if (!Enum.IsDefined(typeof(Emoji), emoji)) throw new InvalidEnumArgumentException(nameof(emoji), (Int32)emoji, typeof(Emoji));

        var fieldInfo = typeof(Emoji).GetField(emoji.ToString()) ?? throw new InvalidEnumArgumentException(nameof(emoji), (Int32)emoji, typeof(Emoji));
        if (Attribute.GetCustomAttribute(fieldInfo, typeof(EnumMemberAttribute)) is not EnumMemberAttribute attribute)
            throw new InvalidEnumArgumentException(nameof(emoji), (Int32)emoji, typeof(Emoji));

        return attribute.Value ?? throw new InvalidEnumArgumentException(nameof(emoji), (Int32)emoji, typeof(Emoji));
    }
}
