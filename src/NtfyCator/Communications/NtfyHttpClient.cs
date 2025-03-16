// Copyright (c) 2025 Christian Flessa. All rights reserved.
// This file is licensed under the MIT license. See LICENSE in the project root for more information.
namespace NtfyCator.Communications;

internal class NtfyHttpClient : INtfyHttpClient
{
    private readonly HttpClient _httpClient;

    public NtfyHttpClient(HttpClient httpClient)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }
}
