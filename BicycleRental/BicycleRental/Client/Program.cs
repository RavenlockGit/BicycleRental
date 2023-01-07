using BicycleRental.Client;
using BicycleRental.Client.Repositories;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http;

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

            builder.Services.AddScoped<BicycleRepository>();
            builder.Services.AddScoped<ReservationRepository>();

            await builder.Build().RunAsync();
        }
    }
}