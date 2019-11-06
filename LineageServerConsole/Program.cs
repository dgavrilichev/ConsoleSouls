using System;
using System.Threading;
using System.Threading.Tasks;
using Common;
using LineageServerCommon;

namespace LineageServerConsole
{
    internal static class Program
    {
        private static void Main()
        {
            Console.CursorVisible = false;

            var logger = new ThreadSafeLogger(new ConsoleLogger());
            var server = new ServerMain(logger);

            using (var cts = new CancellationTokenSource())
            {
                Task.Run((() => server.Start(cts.Token)), cts.Token);
                logger.WriteInformation("Press any key to stop server..");
                Console.ReadKey(true);
                cts.Cancel();

                logger.WriteInformation("Press any key to close..");
                Console.ReadKey(true);
            }
        }
    }
}
