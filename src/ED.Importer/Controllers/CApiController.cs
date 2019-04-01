using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ED.Importer.Controllers
{
    [Route("/capi")]
    [Authorize]
    public class CApiController : Controller
    {
        private HttpClient _client;

        public CApiController()
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri("https://companion.orerve.net")
            };
        }

        [Route("{subPath}")]
        public async Task<IActionResult> GetAsync(string subPath)
        {
            var response = await GetCApiAsync(subPath);

            return Content(await response.Content.ReadAsStringAsync(), response.Content.Headers.ContentType.MediaType);
        }
        
        private async Task<HttpResponseMessage> GetCApiAsync(string requestUri)
        {
            var date = DateTime.UtcNow;

            var ticket = await HttpContext.AuthenticateAsync();
            var token = await GetAccessToken();

            return await _client.SendAsync(new HttpRequestMessage(HttpMethod.Get, new Uri(_client.BaseAddress, requestUri))
            {
                Headers =
                {
                    Authorization = new AuthenticationHeaderValue("Bearer", token),
                    Accept =
                    {
                        new MediaTypeWithQualityHeaderValue("application/json")
                    }
                }
            });
        }

        private Task<string> GetAccessToken()
        {
            return HttpContext.GetTokenAsync("access_token");
        }
    }
}