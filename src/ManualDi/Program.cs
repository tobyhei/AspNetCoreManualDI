using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ManualDi
{
    public static class Program
    {
        public static Task Main(string[] args)
            => CreateBuilder(args).Build().RunAsync();

        private static IWebHostBuilder CreateBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
