// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Communications;

using NtfyCator.Messages;
using NtfyCator.Security;
using System.Net.Http.Json;

internal class NtfyHttpClient : INtfyHttpClient
{
    private readonly HttpClient _httpClient;
    private NotificatorSecurity? _security;

    public NtfyHttpClient(HttpClient httpClient)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }

    public async Task SendNotificationAsync(Uri endpoint, NtfyMessage message, CancellationToken cancellationToken = default)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, endpoint)
        {
            Content = JsonContent.Create(message)
        };

        _security?.SecureRequest(request);
        var response = await _httpClient.SendAsync(request, cancellationToken);

        response.EnsureSuccessStatusCode();
    }

    public void SetSecurity(NotificatorSecurity security)
    {
        if (_security is not null)
            throw new InvalidOperationException("Security has already been set.");

        _security = security ?? throw new ArgumentNullException(nameof(security));
    }
}
