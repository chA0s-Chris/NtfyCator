// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
using NtfyCatorTools;


var emojiOutput = "../../../../NtfyCator/Messages/Emoji.cs";
var text = await EmojiConverter.CreateEmojis();

await File.WriteAllTextAsync(emojiOutput, text);

