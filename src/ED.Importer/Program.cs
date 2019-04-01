using ED.Tools.Inara;
using ED.Tools.Inara.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ED.Importer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
