using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using NGate;
using System.Threading.Tasks;

namespace Outloud.Api
{
    public class Program
    {
        public static async Task Main(string[] args)
            => await WebHost.CreateDefaultBuilder(args).UseNGate().Build().RunAsync();
    }
}
