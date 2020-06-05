using Microsoft.AspNetCore.Hosting;
using System;
using Microsoft.AspNetCore;

namespace ProjectHerculesService.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                BuildWebHost(args).Run();
                //CreateWebHostBuilder(args);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {

            }
            //CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            IWebHostBuilder builder = WebHost.CreateDefaultBuilder(args);

#if DEBUG
            builder.UseEnvironment(EnvironmentName.Development);
            //need the rest of the environments later
#endif
            return builder
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseKestrel() //was added after things broke
                .ConfigureKestrel((context, options) => { }) //was added after things broke
                .Build();
        }
            //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            //    WebHost.CreateDefaultBuilder(args)
            //        .UseKestrel()
            //        .ConfigureKestrel((context, options) => { })
            //        .UseStartup<Startup>();
    }
}
