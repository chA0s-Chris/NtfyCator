// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Messages;

/// <summary>
/// Builder for creating ntfy messages.
/// </summary>
public sealed class NtfyMessageBuilder : NtfyMessageBuilderBase<NtfyMessageBuilder>
{
    /// <summary>
    /// Initializes new instance of the <see cref="NtfyMessageBuilder"/> class.
    /// </summary>
    /// <param name="topic">The topic of the message.</param>
    public NtfyMessageBuilder(String topic) : base(topic) { }

    /// <summary>
    /// Builds the message.
    /// </summary>
    /// <returns>The built <see cref="NtfyMessage"/>.</returns>
    public NtfyMessage Build() => Message;

    /// <summary>
    /// Converts the builder to a <see cref="NtfyMessage"/>.
    /// </summary>
    /// <param name="builder">The builder instance.</param>
    public static explicit operator NtfyMessage(NtfyMessageBuilder builder) => builder.Build();
}
