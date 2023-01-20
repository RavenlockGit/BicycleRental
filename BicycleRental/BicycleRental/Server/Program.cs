using BicycleRental.Server.Data;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllersWithViews().AddOData();
            builder.Services.AddRazorPages();

            //todo remove
            //todo move somewhere else
            //var dbName = "testdb.db";
            //if (File.Exists(dbName))
            //{
            //    File.Delete(dbName);
            //}

            //Controllers including OData
            builder.Services.AddControllers().AddOData(options =>
            {
                options.Select().Filter().OrderBy();
            });

            builder.Services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();


            app.MapRazorPages();
            app.MapControllers();
            app.MapFallbackToFile("index.html");

            app.Run();
        }
    }
}