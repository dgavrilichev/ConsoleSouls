using System;
using System.Threading;
using System.Threading.Tasks;
using Common;
using JetBrains.Annotations;

namespace LineageServerCommon
{
    public sealed class ServerMain : IDisposable
    {
        [NotNull] private readonly ILogger _logger;

        public ServerMain([NotNull] ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.WriteInformation($"Starting {nameof(ServerMain)}.");

            try
            {
                await Task.Delay(-1, cancellationToken);
            }
            catch (TaskCanceledException)
            {
                _logger.WriteDebugInformation("Main task was canceled.");
            }

            _logger.WriteInformation($"{nameof(ServerMain)} stopped.");
        }

        public void Dispose()
        {
        }
    }
}
