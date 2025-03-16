// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Messages;

public sealed class NtfyMessageBuilder : NtfyMessageBuilderBase
{
    public NtfyMessageBuilder(String topic) : base(topic) { }

    public NtfyMessage Build() => Message;

    public static explicit operator NtfyMessage(NtfyMessageBuilder builder) => builder.Build();
}
