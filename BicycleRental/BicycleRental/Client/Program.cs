using BicycleRental.Client.Repositories;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BicycleRental.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddHttpClient("public-client", client =>
            {
                client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
                client.Timeout = TimeSpan.FromSeconds(300);
            });

            builder.Services.AddHttpClient("auth-client", client =>
            {
                client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
            }).AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();


            builder.Services.AddAuthorizationCore();

            builder.Services.AddOidcAuthentication(options =>
    {
        //options.ProviderOptions.Authority = "http://localhost:8080/auth/realms/myrealm";
        options.ProviderOptions.Authority = "http://localhost:8080/realms/myrealm";
        //options.ProviderOptions.ClientId = "kiddy-client";
        options.ProviderOptions.ClientId = "myclient";
        options.ProviderOptions.ResponseType = "code";
        options.ProviderOptions.DefaultScopes.Clear();
        options.ProviderOptions.DefaultScopes.Add("openid");
        options.ProviderOptions.DefaultScopes.Add("profile");
        //options.ProviderOptions.DefaultScopes.Add("???");
        //TODO:Audience

        options.UserOptions.RoleClaim = "role";
        options.UserOptions.NameClaim = "preffered_username"; //prefrerred_username
    });

            builder.Services.AddScoped<BicycleRepository>();
            builder.Services.AddScoped<ReservationRepository>();

            await builder.Build().RunAsync();
        }
    }
}