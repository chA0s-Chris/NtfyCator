// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Messages;

/// <summary>
/// Represents priority levels for NtfyCator.
/// </summary>
public enum NtfyPriority
{
    /// <summary>
    /// Represents the minimum priority level.
    /// </summary>
    Min = 1,

    /// <summary>
    /// Represents a low priority level.
    /// </summary>
    Low = 2,

    /// <summary>
    /// Represents the default priority level.
    /// </summary>
    Default = 3,

    /// <summary>
    /// Represents a high priority level.
    /// </summary>
    High = 4,

    /// <summary>
    /// Represents the maximum priority level.
    /// </summary>
    Max = 5
}
