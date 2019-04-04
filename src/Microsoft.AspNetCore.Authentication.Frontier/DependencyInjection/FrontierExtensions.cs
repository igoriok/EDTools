using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Frontier;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class FrontierExtensions
    {
        public static AuthenticationBuilder AddFrontier(
            this AuthenticationBuilder builder)
        {
            return builder.AddFrontier(FrontierDefaults.AuthenticationScheme, (_) => { });
        }

        public static AuthenticationBuilder AddFrontier(
            this AuthenticationBuilder builder,
            Action<FrontierOptions> configureOptions)
        {
            return builder.AddFrontier(FrontierDefaults.AuthenticationScheme, configureOptions);
        }

        public static AuthenticationBuilder AddFrontier(
            this AuthenticationBuilder builder,
            string authenticationScheme,
            Action<FrontierOptions> configureOptions)
        {
            return builder.AddFrontier(authenticationScheme, FrontierDefaults.DisplayName, configureOptions);
        }

        public static AuthenticationBuilder AddFrontier(
            this AuthenticationBuilder builder,
            string authenticationScheme,
            string displayName,
            Action<FrontierOptions> configureOptions)
        {
            return builder.AddOAuth<FrontierOptions, FrontierHandler>(authenticationScheme, displayName, configureOptions);
        }
    }
}