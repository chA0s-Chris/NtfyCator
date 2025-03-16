// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

using NtfyCator;
using NtfyCator.Communications;
using NtfyCator.Options;

public static class ServiceCollectionExtensions
{
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
