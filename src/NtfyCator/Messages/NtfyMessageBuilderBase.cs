// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Messages;

using System.ComponentModel;

/// <summary>
/// Base class for building ntfy messages.
/// </summary>
/// <typeparam name="TBuilder">The type of the builder.</typeparam>
public abstract class NtfyMessageBuilderBase<TBuilder> where TBuilder : NtfyMessageBuilderBase<TBuilder>
{
    private readonly NtfyMessage _message;

    /// <summary>
    /// Initializes a new instance of the <see cref="NtfyMessageBuilderBase{TBuilder}"/> class.
    /// </summary>
    /// <param name="topic">The topic of the message.</param>
    /// <exception cref="ArgumentException">Thrown when the topic is <see langword="null"/> or whitespace.</exception>
    protected NtfyMessageBuilderBase(String topic)
    {
        if (String.IsNullOrWhiteSpace(topic)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(topic));

        _message = new()
        {
            Topic = topic
        };
    }

    /// <summary>
    /// Gets the message being built.
    /// </summary>
    protected NtfyMessage Message => _message;

    /// <summary>
    /// Adds an action to the message.
    /// </summary>
    /// <param name="action">The action to add.</param>
    /// <returns>The builder instance.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the action is null.</exception>
    public TBuilder WithAction(NtfyAction action)
    {
        if (action == null) throw new ArgumentNullException(nameof(action));

        _message.Actions ??= [];
        _message.Actions.Add(action);

        return (TBuilder)this;
    }

    /// <summary>
    /// Adds multiple actions to the message.
    /// </summary>
    /// <param name="actions">The actions to add.</param>
    /// <returns>The builder instance.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the actions array is null.</exception>
    public TBuilder WithActions(params NtfyAction[] actions)
    {
        if (actions == null) throw new ArgumentNullException(nameof(actions));

        foreach (var action in actions)
        {
            WithAction(action);
        }

        return (TBuilder)this;
    }

    /// <summary>
    /// Adds an attachment to the message using a URI string.
    /// </summary>
    /// <param name="uri">The URI of the attachment.</param>
    /// <param name="name">The name of the attachment (optional).</param>
    /// <returns>The builder instance.</returns>
    /// <exception cref="ArgumentException">Thrown when the URI is null or whitespace.</exception>
    public TBuilder WithAttachment(String uri, String? name = null)
    {
        if (String.IsNullOrWhiteSpace(uri)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(uri));
        return WithAttachment(new Uri(uri, UriKind.Absolute), name);
    }

    /// <summary>
    /// Adds an attachment to the message using a URI.
    /// </summary>
    /// <param name="uri">The URI of the attachment.</param>
    /// <param name="name">The name of the attachment (optional).</param>
    /// <returns>The builder instance.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the URI is null.</exception>
    public TBuilder WithAttachment(Uri uri, String? name = null)
    {
        if (uri == null) throw new ArgumentNullException(nameof(uri));

        _message.AttachmentUri = uri;
        _message.AttachmentName = name;
        return (TBuilder)this;
    }

    /// <summary>
    /// Sets the body of the message.
    /// </summary>
    /// <param name="body">The body content.</param>
    /// <param name="useMarkdown">Indicates whether to use Markdown formatting.</param>
    /// <returns>The builder instance.</returns>
    /// <exception cref="ArgumentException">Thrown when the body is null or whitespace.</exception>
    public TBuilder WithBody(String body, Boolean useMarkdown = false)
    {
        if (String.IsNullOrWhiteSpace(body)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(body));

        if (useMarkdown)
            _message.UseMarkdown = true;

        _message.Body = body;
        return (TBuilder)this;
    }

    /// <summary>
    /// Sets the click URI of the message using a URI string.
    /// </summary>
    /// <param name="uri">The URI string.</param>
    /// <returns>The builder instance.</returns>
    /// <exception cref="ArgumentException">Thrown when the URI is null or whitespace.</exception>
    public TBuilder WithClickUri(String uri)
    {
        if (String.IsNullOrWhiteSpace(uri)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(uri));
        return WithClickUri(new Uri(uri, UriKind.Absolute));
    }

    /// <summary>
    /// Sets the click URI of the message using a URI.
    /// </summary>
    /// <param name="uri">The URI.</param>
    /// <returns>The builder instance.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the URI is null.</exception>
    public TBuilder WithClickUri(Uri uri)
    {
        if (uri == null) throw new ArgumentNullException(nameof(uri));

        _message.ClickUri = uri;
        return (TBuilder)this;
    }

    /// <summary>
    /// Sets the email address associated with the message.
    /// </summary>
    /// <param name="email">The email address.</param>
    /// <returns>The builder instance.</returns>
    /// <exception cref="ArgumentException">Thrown when the email is null or whitespace.</exception>
    public TBuilder WithEmail(String email)
    {
        if (String.IsNullOrWhiteSpace(email)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(email));

        _message.Email = email;
        return (TBuilder)this;
    }

    /// <summary>
    /// Sets the icon URI of the message using a URI string.
    /// </summary>
    /// <param name="uri">The URI string.</param>
    /// <returns>The builder instance.</returns>
    /// <exception cref="ArgumentException">Thrown when the URI is null or whitespace.</exception>
    public TBuilder WithIconUri(String uri)
    {
        if (String.IsNullOrWhiteSpace(uri)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(uri));
        return WithIconUri(new Uri(uri, UriKind.Absolute));
    }

    /// <summary>
    /// Sets the icon URI of the message using a URI.
    /// </summary>
    /// <param name="uri">The URI.</param>
    /// <returns>The builder instance.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the URI is null.</exception>
    public TBuilder WithIconUri(Uri uri)
    {
        if (uri == null) throw new ArgumentNullException(nameof(uri));

        _message.IconUri = uri;
        return (TBuilder)this;
    }

    /// <summary>
    /// Sets the body of the message using Markdown formatting.
    /// </summary>
    /// <param name="body">The body content.</param>
    /// <returns>The builder instance.</returns>
    public TBuilder WithMarkdownBody(String body)
        => WithBody(body, true);

    /// <summary>
    /// Sets the phone number associated with the message.
    /// </summary>
    /// <param name="phoneNumber">The phone number.</param>
    /// <returns>The builder instance.</returns>
    /// <exception cref="ArgumentException">Thrown when the phone number is null or whitespace.</exception>
    public TBuilder WithPhoneNumber(String phoneNumber)
    {
        if (String.IsNullOrWhiteSpace(phoneNumber)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(phoneNumber));

        PhoneNumberHelper.Validate(phoneNumber);
        _message.PhoneNumber = phoneNumber;
        return (TBuilder)this;
    }

    /// <summary>
    /// Sets the priority of the message.
    /// </summary>
    /// <param name="priority">The priority level.</param>
    /// <returns>The builder instance.</returns>
    /// <exception cref="InvalidEnumArgumentException">Thrown when the priority is not a valid enum value.</exception>
    public TBuilder WithPriority(NtfyPriority priority)
    {
        if (!Enum.IsDefined(typeof(NtfyPriority), priority)) throw new InvalidEnumArgumentException(nameof(priority), (Int32)priority, typeof(NtfyPriority));

        _message.Priority = priority;
        return (TBuilder)this;
    }

    /// <summary>
    /// Enables scheduled delivery of the message.
    /// </summary>
    /// <param name="delayOrTimestamp">The delay or timestamp for delivery.</param>
    /// <returns>The builder instance.</returns>
    /// <exception cref="ArgumentException">Thrown when the delay or timestamp is null or whitespace.</exception>
    public TBuilder WithScheduledDelivery(String delayOrTimestamp)
    {
        if (String.IsNullOrWhiteSpace(delayOrTimestamp)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(delayOrTimestamp));

        _message.Delay = delayOrTimestamp;
        return (TBuilder)this;
    }

    /// <summary>
    /// Adds a tag to the message.
    /// </summary>
    /// <param name="tag">The tag to add.</param>
    /// <returns>The builder instance.</returns>
    /// <exception cref="ArgumentException">Thrown when the tag is null or whitespace.</exception>
    public TBuilder WithTag(String tag)
    {
        if (String.IsNullOrWhiteSpace(tag)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(tag));

        _message.Tags ??= [];
        _message.Tags.Add(tag);
        return (TBuilder)this;
    }

    /// <summary>
    /// Adds a tag to the message using an emoji.
    /// </summary>
    /// <param name="emoji">The emoji to add as a tag.</param>
    /// <returns>The builder instance.</returns>
    /// <exception cref="InvalidEnumArgumentException">Thrown when the emoji is not a valid enum value.</exception>
    public TBuilder WithTag(Emoji emoji)
    {
        if (!Enum.IsDefined(typeof(Emoji), emoji)) throw new InvalidEnumArgumentException(nameof(emoji), (Int32)emoji, typeof(Emoji));

        _message.Tags ??= [];
        _message.Tags.Add(EmojiHelper.GetEmojiValue(emoji));
        return (TBuilder)this;
    }

    /// <summary>
    /// Adds multiple tags to the message using emojis.
    /// </summary>
    /// <param name="emojis">The emojis to add as tags.</param>
    /// <returns>The builder instance.</returns>
    public TBuilder WithTags(IEnumerable<Emoji> emojis)
        => WithTags(emojis.ToArray());

    /// <summary>
    /// Adds multiple tags to the message using emojis.
    /// </summary>
    /// <param name="emojis">The emojis to add as tags.</param>
    /// <returns>The builder instance.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the emojis array is null.</exception>
    /// <exception cref="ArgumentException">Thrown when the emojis array is empty.</exception>
    public TBuilder WithTags(params Emoji[] emojis)
    {
        if (emojis == null) throw new ArgumentNullException(nameof(emojis));
        if (emojis.Length == 0) throw new ArgumentException("Value cannot be an empty collection.", nameof(emojis));

        _message.Tags ??= [];
        _message.Tags.AddRange(emojis.Select(EmojiHelper.GetEmojiValue));
        return (TBuilder)this;
    }

    /// <summary>
    /// Adds multiple tags to the message.
    /// </summary>
    /// <param name="tags">The tags to add.</param>
    /// <returns>The builder instance.</returns>
    public TBuilder WithTags(IEnumerable<String> tags)
        => WithTags(tags.ToArray());

    /// <summary>
    /// Adds multiple tags to the message.
    /// </summary>
    /// <param name="tags">The tags to add.</param>
    /// <returns>The builder instance.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the tags array is null.</exception>
    /// <exception cref="ArgumentException">Thrown when the tags array is empty.</exception>
    public TBuilder WithTags(params String[] tags)
    {
        if (tags == null) throw new ArgumentNullException(nameof(tags));
        if (tags.Length == 0) throw new ArgumentException("Value cannot be an empty collection.", nameof(tags));

        _message.Tags ??= [];
        _message.Tags.AddRange(tags);
        return (TBuilder)this;
    }

    /// <summary>
    /// Sets the title of the message.
    /// </summary>
    /// <param name="title">The title of the message.</param>
    /// <returns>The builder instance.</returns>
    /// <exception cref="ArgumentException">Thrown when the title is null or whitespace.</exception>
    public TBuilder WithTitle(String title)
    {
        if (String.IsNullOrWhiteSpace(title)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(title));

        _message.Title = title;
        return (TBuilder)this;
    }

    /// <summary>
    /// Sets the phone number as verified.
    /// </summary>
    /// <returns>The builder instance.</returns>
    public TBuilder WithVerifiedPhoneNumber()
    {
        _message.PhoneNumber = "yes";
        return (TBuilder)this;
    }
}
