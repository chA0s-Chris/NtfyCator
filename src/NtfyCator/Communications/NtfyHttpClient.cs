// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Communications;

using NtfyCator.Communications.Exceptions;
using NtfyCator.Messages;
using NtfyCator.Security;
using System.Net;
using System.Net.Http.Json;

/// <summary>
/// Implementation of an HTTP client to transport notifications.
/// </summary>
internal class NtfyHttpClient : INtfyHttpClient
{
    private readonly HttpClient _httpClient;
    private NotificatorSecurity? _security;

    /// <summary>
    /// Initializes a new instance of the <see cref="NtfyHttpClient"/> class.
    /// </summary>
    /// <param name="httpClient">Instance of <see cref="HttpClient"/> to use for sending requests.</param>
    public NtfyHttpClient(HttpClient httpClient)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }

    /// <inheritdoc/>
    public async Task SendNotificationAsync(Uri endpoint, NtfyMessage message, CancellationToken cancellationToken = default)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, endpoint)
        {
            Content = JsonContent.Create(message)
        };

        _security?.SecureRequest(request);
        try
        {
            var response = await _httpClient.SendAsync(request, cancellationToken);
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException e)
        {
#if NETSTANDARD2_0
            throw new NtfyException("Error sending notification.", null, e);
#else
            throw e.StatusCode switch
            {
                HttpStatusCode.Unauthorized => new NtfyUnauthorizedException(e),
                HttpStatusCode.Forbidden => new NtfyForbiddenException(e),
                HttpStatusCode.NotFound => new NtfyNotFoundException(e),
                HttpStatusCode.RequestEntityTooLarge => new NtfyTooLargeException(e),
                HttpStatusCode.TooManyRequests => new NtfyRateLimitReachedException(e),
                _ => new NtfyException("Error sending notification.", e.StatusCode, e)
            };
#endif
        }
    }

    /// <inheritdoc/>
    public void SetSecurity(NotificatorSecurity security)
    {
        if (_security is not null)
            throw new InvalidOperationException("Security has already been set.");

        _security = security ?? throw new ArgumentNullException(nameof(security));
    }
}
