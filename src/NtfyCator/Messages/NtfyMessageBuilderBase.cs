// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Messages;

using System.ComponentModel;

public abstract class NtfyMessageBuilderBase<TBuilder> where TBuilder : NtfyMessageBuilderBase<TBuilder>
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

    public TBuilder WithAttachment(String uri, String? name = null)
    {
        if (String.IsNullOrWhiteSpace(uri)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(uri));
        return WithAttachment(new Uri(uri, UriKind.Absolute), name);
    }

    public TBuilder WithAttachment(Uri uri, String? name = null)
    {
        if (uri == null) throw new ArgumentNullException(nameof(uri));

        _message.AttachmentUri = uri;
        _message.AttachmentName = name;
        return (TBuilder)this;
    }

    public TBuilder WithBody(String body, Boolean useMarkdown = false)
    {
        if (String.IsNullOrWhiteSpace(body)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(body));

        if (useMarkdown)
            _message.UseMarkdown = true;

        _message.Body = body;
        return (TBuilder)this;
    }

    public TBuilder WithClickUri(String uri)
    {
        if (String.IsNullOrWhiteSpace(uri)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(uri));
        return WithClickUri(new Uri(uri, UriKind.Absolute));
    }

    public TBuilder WithClickUri(Uri uri)
    {
        if (uri == null) throw new ArgumentNullException(nameof(uri));

        _message.ClickUri = uri;
        return (TBuilder)this;
    }

    public TBuilder WithEmail(String email)
    {
        if (String.IsNullOrWhiteSpace(email)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(email));

        _message.Email = email;
        return (TBuilder)this;
    }

    public TBuilder WithIconUri(String uri)
    {
        if (String.IsNullOrWhiteSpace(uri)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(uri));
        return WithIconUri(new Uri(uri, UriKind.Absolute));
    }

    public TBuilder WithIconUri(Uri uri)
    {
        if (uri == null) throw new ArgumentNullException(nameof(uri));

        _message.IconUri = uri;
        return (TBuilder)this;
    }

    public TBuilder WithMarkdownBody(String body)
        => WithBody(body, true);

    public TBuilder WithPhoneNumber(String phoneNumber)
    {
        if (String.IsNullOrWhiteSpace(phoneNumber)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(phoneNumber));

        PhoneNumberHelper.Validate(phoneNumber);
        _message.PhoneNumber = phoneNumber;
        return (TBuilder)this;
    }

    public TBuilder WithPriority(NtfyPriority priority)
    {
        if (!Enum.IsDefined(typeof(NtfyPriority), priority)) throw new InvalidEnumArgumentException(nameof(priority), (Int32)priority, typeof(NtfyPriority));

        _message.Priority = priority;
        return (TBuilder)this;
    }

    public TBuilder WithTag(String tag)
    {
        if (String.IsNullOrWhiteSpace(tag)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(tag));

        _message.Tags ??= [];
        _message.Tags.Add(tag);
        return (TBuilder)this;
    }

    public TBuilder WithTag(Emoji emoji)
    {
        if (!Enum.IsDefined(typeof(Emoji), emoji)) throw new InvalidEnumArgumentException(nameof(emoji), (Int32)emoji, typeof(Emoji));

        _message.Tags ??= [];
        _message.Tags.Add(EmojiHelper.GetEmojiValue(emoji));
        return (TBuilder)this;
    }

    public TBuilder WithTags(IEnumerable<Emoji> emojis)
        => WithTags(emojis.ToArray());

    public TBuilder WithTags(params Emoji[] emojis)
    {
        if (emojis == null) throw new ArgumentNullException(nameof(emojis));
        if (emojis.Length == 0) throw new ArgumentException("Value cannot be an empty collection.", nameof(emojis));

        _message.Tags ??= [];
        _message.Tags.AddRange(emojis.Select(EmojiHelper.GetEmojiValue));
        return (TBuilder)this;
    }

    public TBuilder WithTags(IEnumerable<String> tags)
        => WithTags(tags.ToArray());

    public TBuilder WithTags(params String[] tags)
    {
        if (tags == null) throw new ArgumentNullException(nameof(tags));
        if (tags.Length == 0) throw new ArgumentException("Value cannot be an empty collection.", nameof(tags));

        _message.Tags ??= [];
        _message.Tags.AddRange(tags);
        return (TBuilder)this;
    }

    public TBuilder WithTitle(String title)
    {
        if (String.IsNullOrWhiteSpace(title)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(title));

        _message.Title = title;
        return (TBuilder)this;
    }

    public TBuilder WithVerifiedPhoneNumber()
    {
        _message.PhoneNumber = "yes";
        return (TBuilder)this;
    }
}
