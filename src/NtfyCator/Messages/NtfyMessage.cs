// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Messages;

using System.Text.Json.Serialization;

/// <summary>
/// Represents a notification message.
/// </summary>
public class NtfyMessage
{
    /// <summary>
    /// Gets or sets the actions associated with the message.
    /// </summary>
    [JsonPropertyName("actions")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<NtfyAction>? Actions { get; set; }

    /// <summary>
    /// Gets or sets the name of the attachment.
    /// </summary>
    [JsonPropertyName("filename")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public String? AttachmentName { get; set; }

    /// <summary>
    /// Gets or sets the URI of the attachment.
    /// </summary>
    [JsonPropertyName("attach")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Uri? AttachmentUri { get; set; }

    /// <summary>
    /// Gets or sets the body of the message.
    /// </summary>
    [JsonPropertyName("message")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public String? Body { get; set; }

    /// <summary>
    /// Gets or sets the URI to be opened when the message is clicked.
    /// </summary>
    [JsonPropertyName("click")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Uri? ClickUri { get; set; }

    /// <summary>
    /// Gets or sets the delay or timestamp for scheduled delivery of the message.
    /// </summary>
    [JsonPropertyName("delay")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public String? Delay { get; set; }

    /// <summary>
    /// Gets or sets the email associated with the message.
    /// </summary>
    [JsonPropertyName("email")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public String? Email { get; set; }

    /// <summary>
    /// Gets or sets the URI of the icon.
    /// </summary>
    [JsonPropertyName("icon")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Uri? IconUri { get; set; }

    /// <summary>
    /// Gets or sets the phone number to be called.
    /// </summary>
    [JsonPropertyName("call")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public String? PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the priority of the message.
    /// </summary>
    [JsonPropertyName("priority")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public NtfyPriority? Priority { get; set; }

    /// <summary>
    /// Gets or sets the tags associated with the message.
    /// </summary>
    [JsonPropertyName("tags")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<String>? Tags { get; set; }

    /// <summary>
    /// Gets or sets the title of the message.
    /// </summary>
    [JsonPropertyName("title")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public String? Title { get; set; }

    /// <summary>
    /// Gets the topic of the message.
    /// </summary>
    [JsonPropertyName("topic")]
    public required String Topic { get; init; }

    /// <summary>
    /// Gets or sets a value indicating whether the message body uses Markdown.
    /// </summary>
    [JsonPropertyName("markdown")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Boolean? UseMarkdown { get; set; }
}
