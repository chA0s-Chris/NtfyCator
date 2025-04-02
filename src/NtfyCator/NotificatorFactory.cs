// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator;

using Microsoft.Extensions.Options;
using NtfyCator.Communications;
using NtfyCator.Options;

/// <summary>
/// Factory class for creating instances of <see cref="INotificator"/>.
/// </summary>
/// <remarks>
/// Offers easy access to an instance of <see cref="INotificator"/> when not using dependency injection.
/// </remarks>
public static class NotificatorFactory
{
    private static HttpClient? _httpClient;

    /// <summary>
    /// Creates an instance of <see cref="INotificator"/>.
    /// </summary>
    /// <param name="httpClient">An optional <see cref="HttpClient"/> to be used by the notificator.</param>
    /// <param name="options">Optional configuration options for the notificator.</param>
    /// <returns>An instance of <see cref="INotificator"/>.</returns>
    public static INotificator CreateNotificator(HttpClient? httpClient = null, NtfyCatorOptions? options = null)
    {
        var ntfyHttpClient = new NtfyHttpClient(httpClient ?? (_httpClient ??= new()));
        var notificator = new Notificator(ntfyHttpClient, new OptionsWrapper<NtfyCatorOptions>(options ?? new NtfyCatorOptions()));
        return notificator;
    }
}
