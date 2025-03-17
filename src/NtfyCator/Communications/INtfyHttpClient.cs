// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Communications;

using NtfyCator.Messages;
using NtfyCator.Security;

public interface INtfyHttpClient
{
    Task SendNotificationAsync(Uri endpoint, NtfyMessage message, CancellationToken cancellationToken = default);

    void SetSecurity(NotificatorSecurity security);
}
