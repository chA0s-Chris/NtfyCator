// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCatorTools;

using System.Reflection;
using System.Text;

public static class EmojiConverter
{
    private static readonly Dictionary<String, String> _emojiReplacements = new()
    {
        { "100", "OneHundred" },
        { "1", "MinusOne" },
        { "+1", "PlusOne" },
        { "1stPlaceMedal", "FirstPlaceMedal" },
        { "2ndPlaceMedal", "SecondPlaceMedal" },
        { "3rdPlaceMedal", "ThirdPlaceMedal" },
        { "8ball", "EightBall" },
        { "1234", "OneTwoThreeFour" }
    };

    private const String EmojiData = "NtfyCatorTools.Resources.Emojis";

    public static async Task<String> CreateEmojis()
    {
        var builder = new StringBuilder();

        builder.AppendLine("namespace NtfyCator.Messages;");
        builder.AppendLine();
        builder.AppendLine("using System.Runtime.Serialization;");
        builder.AppendLine();

        builder.AppendLine("public enum Emoji");
        builder.AppendLine("{");


        await using var emojiStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(EmojiData) ??
                                      throw new InvalidOperationException("Could not find emoji data.");
        using var reader = new StreamReader(emojiStream);

        while (await reader.ReadLineAsync() is { } line)
        {
            var emoji = SplitLine(line);
            AddEmoji(builder, emoji);
        }

        builder.AppendLine("}");

        return builder.ToString();
    }

    internal static void AddEmoji(StringBuilder builder, Emoji emoji)
    {
        var name = CreateEmojiName(emoji.Name);

        builder.AppendLine("    /// <summary>");
        builder.AppendLine($"    /// {emoji.Unicode}");
        builder.AppendLine("    /// </summary>");
        builder.AppendLine($"    [EnumMember(Value = \"{emoji.Name}\")]");
        builder.AppendLine($"    {name},");
        builder.AppendLine();
    }

    internal static String CreateEmojiName(ReadOnlySpan<Char> name)
    {
        if (name.IsEmpty)
            return String.Empty;

        var builder = new StringBuilder();
        var capitalizeNext = true;

        foreach (var character in name)
        {
            if (character is '_' or '-')
            {
                capitalizeNext = true;
            }
            else
            {
                if (capitalizeNext)
                {
                    builder.Append(Char.ToUpper(character));
                    capitalizeNext = false;
                }
                else
                {
                    builder.Append(character);
                }
            }
        }

        var emojiName = builder.ToString();
        if (_emojiReplacements.TryGetValue(emojiName, out var replacement))
        {
            emojiName = replacement;
        }

        return emojiName;
    }

    internal static Emoji SplitLine(String line)
    {
        var span = line.AsSpan();
        var separatorIndex = span.IndexOf('\t');
        if (separatorIndex < 0)
        {
            separatorIndex = span.IndexOf(' ');
        }

        if (separatorIndex < 0)
            throw new InvalidOperationException("Could not find separator in emoji line.");

        return new()
        {
            Name = span[..separatorIndex],
            Unicode = span[(separatorIndex + 1)..]
        };
    }


    internal ref struct Emoji
    {
        public ReadOnlySpan<Char> Name;
        public ReadOnlySpan<Char> Unicode;
    }
}
