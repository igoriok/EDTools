using System;
using System.Threading.Tasks;
using AutoMapper;
using ED.Importer.Options;
using ED.Journal.Events;
using ED.Tools.Inara.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Frontier;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace ED.Importer
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IHostingEnvironment Environment { get; }

        public Startup(IConfiguration configuration, IHostingEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<InaraOptions>(Configuration.GetSection("Inara"));
            services.Configure<FrontierAuthOptions>(Configuration.GetSection("Frontier"));
            services
                .AddOptions<FrontierOptions>(FrontierDefaults.AuthenticationScheme)
                .Configure<IOptions<FrontierAuthOptions>>((oauthOptions, frontierAuthOptions) =>
                {
                    oauthOptions.ClientId = frontierAuthOptions.Value.ClientId;
                    oauthOptions.ClientSecret = frontierAuthOptions.Value.ClientSecret;
                });

            services
                .AddAutoMapper(cfg => { cfg.CreateMap<Statistics, CommanderGameStatistics>(); });

            services
                .AddAuthentication(o =>
                {
                    o.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    o.DefaultChallengeScheme = FrontierDefaults.AuthenticationScheme;
                })
                .AddCookie()
                .AddFrontier(o =>
                {
                    o.SaveTokens = true;
                    o.Events = new OAuthEvents
                    {
                        OnCreatingTicket = (ctx) =>
                        {
                            if (ctx.ExpiresIn.HasValue)
                            {
                                ctx.Properties.ExpiresUtc = DateTimeOffset.UtcNow.Add(ctx.ExpiresIn.Value);
                            }

                            return Task.CompletedTask;
                        }
                    };
                });

            services
                .AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}