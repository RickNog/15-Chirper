using Chirper.WebApi.Infrastructure;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Web.Http;

// Tell owin about our new entry point
[assembly: OwinStartup(typeof(Chirper.WebApi.Startup))]
namespace Chirper.WebApi
{
    public class Startup
    {
        public bool AllowInsecureHttp { get; private set; }
        public void Configuration(IAppBuilder app)
        {
            // Map url routes to the right C# methods
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);

            ConfigureOAuth(app);

            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(config);
        }

        // Setup OAuth
        public void ConfigureOAuth(IAppBuilder app)
        {
            // Configure authentication
            var authenticationOptions = new OAuthBearerAuthenticationOptions();
            app.UseOAuthBearerAuthentication(authenticationOptions);

            // Configure authentication, configure token
            var authorizationOptions = new OAuthAuthorizationServerOptions
            {
                // For delivery only
                AllowInsecureHttp = true,
                // Map token api endpoint
                TokenEndpointPath = new PathString("/api/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new ChirperAuthorizationServerProvider()
            };
            app.UseOAuthAuthorizationServer(authorizationOptions);
        }
    }
}