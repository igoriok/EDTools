using ED.Tools.Inara.Converters;
using ED.Tools.Inara.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ED.Tools.Inara
{
    public class InaraApiClient : IDisposable
    {
        private static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            DateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ssK",
            DateTimeZoneHandling = DateTimeZoneHandling.Utc,
        };

        private readonly HttpClient _client;

        public InaraApiClient()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://inara.cz/inapi/v1/")
            };
        }

        public async Task<Response> SendAsync(Request request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestContent = JsonConvert.SerializeObject(request, JsonSerializerSettings);

            using (var httpRequest = new HttpRequestMessage(HttpMethod.Post, _client.BaseAddress)
            {
                Headers =
                {
                    Accept =
                    {
                        new MediaTypeWithQualityHeaderValue("application/json")
                    }
                },
                Content = new StringContent(requestContent, Encoding.UTF8, "application/json")
            })
            {
                using (var httpResponse = await _client.SendAsync(httpRequest, cancellationToken))
                {
                    httpResponse.EnsureSuccessStatusCode();

                    var content = await httpResponse.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<Response>(content, new ResponseEventsConverter(request.Events));
                }
            }
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}