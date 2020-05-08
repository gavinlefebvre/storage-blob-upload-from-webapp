using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace VideoUploadWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureKestrel((context, options) =>
                {
                    // Handle requests up to 200 MB
                    options.Limits.MaxRequestBodySize = 209715200;
                })
                .Build();
    }
}
