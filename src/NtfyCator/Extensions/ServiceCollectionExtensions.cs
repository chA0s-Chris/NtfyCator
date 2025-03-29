// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

using NtfyCator;
using NtfyCator.Communications;
using NtfyCator.Options;

/// <summary>
/// Extension methods for <see cref="IServiceCollection"/> to add NtfyCator services.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds NtfyCator services to the specified <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">The service collection to add services to.</param>
    /// <param name="configureOptions">An optional action to configure <see cref="NtfyCatorOptions"/>.</param>
    /// <param name="configureClient">An optional action to configure the <see cref="HttpClient"/>.</param>
    /// <returns>The same service collection so that multiple calls can be chained.</returns>
    public static IServiceCollection AddNtfyCator(this IServiceCollection services,
                                                  Action<NtfyCatorOptions>? configureOptions = null,
                                                  Action<HttpClient>? configureClient = null)
    {
        services.AddOptions<NtfyCatorOptions>();
        if (configureOptions is not null)
        {
            services.Configure(configureOptions);
        }

        services.AddHttpClient<NtfyHttpClient>(httpClient =>
        {
            configureClient?.Invoke(httpClient);
        });

        services.AddTransient<INtfyHttpClient>(serviceProvider => serviceProvider.GetRequiredService<NtfyHttpClient>());
        services.AddTransient<INotificator, Notificator>();

        return services;
    }
}
