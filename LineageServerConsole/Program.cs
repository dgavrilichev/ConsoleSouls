using System.Threading;
using System.Threading.Tasks;
using Common;
using LineageServerCommon;

namespace LineageServerConsole
{
    internal static class Program
    {
        private static async Task Main()
        {
            var server = new ServerMain(new ThreadSafeLogger(new ConsoleLogger()));
            await server.Start(new CancellationToken());
        }
    }
}
