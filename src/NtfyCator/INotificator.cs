// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator;

using NtfyCator.Messages;

public interface INotificator
{
    Uri ServerUri { get; }

    Task NotifyAsync(NtfyMessage message, CancellationToken cancellationToken = default);

    INotificator WithAccessToken(String accessToken);
}
