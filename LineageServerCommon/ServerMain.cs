using System;
using System.Threading;
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

        public async void Start(CancellationToken cancellationToken)
        {

        }
    }
}
