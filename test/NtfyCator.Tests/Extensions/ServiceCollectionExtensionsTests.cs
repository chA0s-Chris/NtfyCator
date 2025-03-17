// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Tests.Extensions;

using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NtfyCator.Communications;
using NtfyCator.Options;
using NUnit.Framework;

public class ServiceCollectionExtensionsTests
{
    private ServiceCollection _services;

    [Test]
    public void AddNtfyCator_PerformsNecessaryConfiguration()
    {
        _services.AddNtfyCator();

        _services.Should().ContainSingle(s => s.ServiceType == typeof(IHttpClientFactory));
        _services.Should().ContainSingle(s => s.ServiceType == typeof(HttpClient));
        _services.Should().ContainSingle(s => s.ServiceType == typeof(INotificator));
        _services.Should().ContainSingle(s => s.ServiceType == typeof(NtfyHttpClient));
        _services.Should().ContainSingle(s => s.ServiceType == typeof(INtfyHttpClient));
    }

    [Test]
    public void AddNtfyCator_WithConfigureClient_InvokesConfigureClient()
    {
        var count = 0;

        _services.AddNtfyCator(configureClient: _ =>
        {
            count++;
        });

        var serviceProvider = _services.BuildServiceProvider();
        serviceProvider.GetRequiredService<INtfyHttpClient>();

        count.Should().Be(1);
    }

    [Test]
    public void AddNtfyCator_WithConfigureOptions_InvokesConfigureOptions()
    {
        var customUri = "https://myntfy.server.com";

        _services.AddNtfyCator(options =>
        {
            options.Uri = customUri;
        });

        var serviceProvider = _services.BuildServiceProvider();
        serviceProvider.GetRequiredService<IOptions<NtfyCatorOptions>>().Value.Uri.Should().Be(customUri);
    }

    [SetUp]
    public void Setup()
    {
        _services = [];
    }
}


/*    public static IServiceCollection AddNtfyCator(this IServiceCollection services,
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
    }*/
