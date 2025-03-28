// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Security;

public abstract class NotificatorSecurity
{
    public abstract void SecureRequest(HttpRequestMessage request);
}
