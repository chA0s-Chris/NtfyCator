// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Factories;

using NtfyCator.Resources;

internal class NotificatorFactory : INotificatorFactory
{
    private readonly IHttpClientFactory _httpClientFactory;

    public NotificatorFactory(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
    }

    public INotificator Create(String serverUri)
    {
        if (serverUri == null) throw new ArgumentNullException(nameof(serverUri));
        return Create(new Uri(serverUri, UriKind.Absolute));
    }

    public INotificator Create(Uri? serverUri = null)
    {
        var uri = serverUri ?? new(Defaults.ServerUri, UriKind.Absolute);
        var httpClient = _httpClientFactory.CreateClient(Defaults.HttpClientName);

        return new Notificator(uri, httpClient);
    }
}
