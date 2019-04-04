using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;

namespace Microsoft.AspNetCore.Authentication.Frontier
{
    public class FrontierOptions : OAuthOptions
    {
        public FrontierOptions()
        {
            CallbackPath = new PathString("/signin-frontier");
            AuthorizationEndpoint = FrontierDefaults.AuthorizationEndpoint;
            TokenEndpoint = FrontierDefaults.TokenEndpoint;
            UserInformationEndpoint = FrontierDefaults.UserInformationEndpoint;
            Scope.Add("auth");
            Scope.Add("capi");
            ClaimActions.MapJsonKey("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "customer_id");
            ClaimActions.MapJsonKey("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress", "email");
            ClaimActions.MapCustomJson("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", GetUserName);
            ClaimActions.MapJsonKey("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname", "firstname");
            ClaimActions.MapJsonKey("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname", "lastname");
            ClaimActions.MapJsonKey("urn:frontier:platform", "platform");
        }

        private static string GetUserName(JObject user)
        {
            return string.Join(" ", user.Value<string>("firstname"), user.Value<string>("lastname")).Trim();
        }
    }
}