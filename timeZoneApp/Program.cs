using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timeZoneApp.Models;
using timeZoneApp.Data;

namespace timeZoneApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            CreateDbIfNotExists(host);

            host.Run();
        }
        
        
        private static void CreateDbIfNotExists(IHost host){

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<TimeZoneAppContext>();
                    context.Database.EnsureCreated();

                    /*var regions = new Region[]
                    {
                        new Region { RegionId = 1, RegionName = "afghanistan", offset = new TimeSpan(4, 30, 0), offsetType = "positive" }
                    };
                    foreach(Region r in regions)
                    {
                        context.Regions.Add(r);
                    }
                    context.SaveChanges();*/

                    //var yeah = 0;
                    

                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }

            Region regionA = new Region()
            {
                RegionId = 1,
                RegionName = "afghanistan",
                offset = new TimeSpan(4, 30, 0),
                offsetType = "positive"
            };

            //if Region.Name == region.Name
            //
            //public override string ToString() => JsonSerializer.Serialize<Region>(this);

            //public static void getTime(String region)
            //{
            //    TimeOffsets offsets = new TimeOffsets();

            //    RegionName = region;

            //    //String time;

            //    try
            //    {
            //        CurrentDateTime = offsets.getDateTime(region);
            //    }
            //    catch (KeyNotFoundException e)
            //    {
            //        CurrentDateTime = "";
            //    }

            //}

            //public static String getTime()
            //{
            //    if (!CurrentDateTime.Equals(""))
            //    {
            //        return CurrentDateTime;
            //    }
            //    else
            //    {
            //        return "Region/Country was not found";
            //    }
            //}

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
