using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using ED.Journal;
using ED.Journal.Events;
using ED.Tools.Companion.Models;
using Newtonsoft.Json;
using Market = ED.Journal.Events.Market;

namespace ED.Tools.Companion
{
    public class CompanionApiClient : IDisposable
    {
        private readonly JsonSerializer _serializer = new JsonSerializer();
        private readonly HttpClient _client;

        public CompanionApiClient(string accessToken)
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://companion.orerve.net/"),
                DefaultRequestHeaders =
                {
                    Authorization = new AuthenticationHeaderValue("Bearer", accessToken),
                }
            };
        }

        public async Task<Profile> GetProfileAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var httpRequest = new HttpRequestMessage(HttpMethod.Get, new Uri(_client.BaseAddress, "/profile"))
            {
                Headers =
                {
                    Accept = { new MediaTypeWithQualityHeaderValue("application/json") },
                }
            })
            using (var httpResponse = await _client.SendAsync(httpRequest, cancellationToken))
            {
                httpResponse.EnsureSuccessStatusCode();

                using (var stream = await httpResponse.Content.ReadAsStreamAsync())
                using (var textReader = new StreamReader(stream))
                using (var jsonReader = new JsonTextReader(textReader))
                {
                    return _serializer.Deserialize<Profile>(jsonReader);
                }
            }
        }

        public async Task<Market> GetCurrentMarketAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var httpRequest = new HttpRequestMessage(HttpMethod.Get, new Uri(_client.BaseAddress, "/market"))
            {
                Headers =
                {
                    Accept = { new MediaTypeWithQualityHeaderValue("application/json") },
                }
            })
            using (var httpResponse = await _client.SendAsync(httpRequest, cancellationToken))
            {
                httpResponse.EnsureSuccessStatusCode();

                using (var stream = await httpResponse.Content.ReadAsStreamAsync())
                using (var textReader = new StreamReader(stream))
                using (var jsonReader = new JsonTextReader(textReader))
                {
                    return _serializer.Deserialize<Market>(jsonReader);
                }
            }
        }

        public Task<IList<JournalEvent>> GetJournalAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetJournalAsync("/journal", cancellationToken);
        }

        public Task<IList<JournalEvent>> GetJournalAsync(DateTime date, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetJournalAsync($"/journal/{date:yyyy/MMMM/dd}", cancellationToken);
        }

        private async Task<IList<JournalEvent>> GetJournalAsync(string path, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = new List<JournalEvent>();

            using (var httpRequest = new HttpRequestMessage(HttpMethod.Get, new Uri(_client.BaseAddress, path))
            {
                Headers =
                {
                    Accept = { new MediaTypeWithQualityHeaderValue("application/json") },
                }
            })
            {
                HttpResponseMessage httpResponse = null;

                try
                {
                    do
                    {
                        httpResponse?.Dispose();
                        httpResponse = await _client.SendAsync(httpRequest, cancellationToken);
                        httpResponse.EnsureSuccessStatusCode();

                        using (var stream = await httpResponse.Content.ReadAsStreamAsync())
                        {
                            result.AddRange(JournalReader.ReadAll(stream));
                        }
                    }
                    while (httpResponse.StatusCode == HttpStatusCode.PartialContent);
                }
                finally
                {
                    httpResponse?.Dispose();
                }
            }

            return result;
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}