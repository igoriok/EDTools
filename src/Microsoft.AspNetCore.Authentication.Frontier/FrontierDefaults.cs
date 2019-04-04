namespace Microsoft.AspNetCore.Authentication.Frontier
{
    public static class FrontierDefaults
    {
        public const string DisplayName = "Frontier";
        public const string AuthorizationEndpoint = "https://auth.frontierstore.net/auth";
        public const string TokenEndpoint = "https://auth.frontierstore.net/token";
        public const string UserInformationEndpoint = "https://auth.frontierstore.net/me";
        public const string AuthenticationScheme = "Frontier";
    }
}