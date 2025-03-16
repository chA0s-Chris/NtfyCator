// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Factories;

public interface INotificatorFactory
{
    INotificator Create(String serverUri);

    INotificator Create(Uri? serverUri = null);
}
