using System;
using System.Threading;
using System.Threading.Tasks;
using Common;
using JetBrains.Annotations;

namespace LineageServerCommon
{
    public sealed class ServerMain
    {
        [NotNull] private readonly ILogger _logger;

        public ServerMain([NotNull] ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task Start(CancellationToken cancellationToken)
        {
            _logger.WriteInformation($"Starting {nameof(ServerMain)}.");

            await Task.Delay(-1, cancellationToken);

            _logger.WriteInformation($"{nameof(ServerMain)} stopped.");
        }
    }
}
