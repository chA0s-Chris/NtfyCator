// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Messages;

using System.ComponentModel;

public abstract class NtfyMessageBuilderBase
{
    private readonly NtfyMessage _message;

    protected NtfyMessageBuilderBase(String topic)
    {
        if (String.IsNullOrWhiteSpace(topic)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(topic));

        _message = new()
        {
            Topic = topic
        };
    }

    protected NtfyMessage Message => _message;

    public NtfyMessageBuilderBase WithBody(String body, Boolean useMarkdown = false)
    {
        if (String.IsNullOrWhiteSpace(body)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(body));

        _message.Body = body;
        return this;
    }

    public NtfyMessageBuilderBase WithMarkdownBody(String body)
        => WithBody(body, true);

    public NtfyMessageBuilderBase WithPriority(NtfyPriority priority)
    {
        if (!Enum.IsDefined(typeof(NtfyPriority), priority)) throw new InvalidEnumArgumentException(nameof(priority), (Int32)priority, typeof(NtfyPriority));

        _message.Priority = priority;
        return this;
    }

    public NtfyMessageBuilderBase WithTag(String tag)
    {
        if (String.IsNullOrWhiteSpace(tag)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(tag));

        _message.Tags ??= [];
        _message.Tags.Add(tag);
        return this;
    }

    public NtfyMessageBuilderBase WithTags(IEnumerable<String> tags)
        => WithTags(tags.ToArray());

    public NtfyMessageBuilderBase WithTags(params String[] tags)
    {
        if (tags == null) throw new ArgumentNullException(nameof(tags));
        if (tags.Length == 0) throw new ArgumentException("Value cannot be an empty collection.", nameof(tags));

        _message.Tags ??= [];
        _message.Tags.AddRange(tags);
        return this;
    }

    public NtfyMessageBuilderBase WithTitle(String title)
    {
        if (String.IsNullOrWhiteSpace(title)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(title));

        _message.Title = title;
        return this;
    }
}
