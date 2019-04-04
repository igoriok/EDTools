using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;

namespace Microsoft.AspNetCore.Authentication.Frontier
{
    public class FrontierHandler : OAuthHandler<FrontierOptions>
    {
        public FrontierHandler(IOptionsMonitor<FrontierOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock)
            : base(options, logger, encoder, clock)
        {
        }

        protected override async Task<AuthenticationTicket> CreateTicketAsync(ClaimsIdentity identity, AuthenticationProperties properties, OAuthTokenResponse tokens)
        {
            using (var httpRequest = new HttpRequestMessage(HttpMethod.Get, Options.UserInformationEndpoint)
            {
                Headers =
                {
                    Authorization = new AuthenticationHeaderValue("Bearer", tokens.AccessToken)
                }
            })
            {
                using (var httpResponse = await Backchannel.SendAsync(httpRequest, Context.RequestAborted))
                {
                    if (!httpResponse.IsSuccessStatusCode)
                        throw new HttpRequestException($"An error occurred when retrieving Frontier user information ({httpResponse.StatusCode}). Please check if the authentication information is correct.");

                    var user = JObject.Parse(await httpResponse.Content.ReadAsStringAsync());

                    var context = new OAuthCreatingTicketContext(new ClaimsPrincipal(identity), properties, Context, Scheme, Options, Backchannel, tokens, user);
            
                    context.RunClaimActions();
            
                    await Events.CreatingTicket(context);
            
                    return new AuthenticationTicket(context.Principal, context.Properties, Scheme.Name);
                }
            }
        }
    }
}