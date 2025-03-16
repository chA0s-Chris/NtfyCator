// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using NtfyCator;
using NtfyCator.Factories;
using NtfyCator.Options;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddNtfyCator(this IServiceCollection services, Action<NtfyCatorOptions> options)
    {
        services.AddHttpClient();
        services.Configure(NtfyCatorOptions.SectionName, options);

        services.TryAddSingleton<INotificatorFactory, NotificatorFactory>();
        services.TryAddSingleton<INotificator>(serviceProvider =>
        {
            var notificatorOptions = serviceProvider.GetRequiredService<IOptions<NtfyCatorOptions>>().Value;
            var notificatorFactory = serviceProvider.GetRequiredService<INotificatorFactory>();
            return notificatorFactory.Create(notificatorOptions.Uri);
        });

        return services;
    }
}
