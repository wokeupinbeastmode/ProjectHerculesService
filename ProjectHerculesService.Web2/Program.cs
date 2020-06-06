using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using LightInject.Microsoft.AspNetCore.Hosting;

namespace ProjectHerculesService.Web2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseLightInject()
                .UseStartup<Startup>();
    }
}
