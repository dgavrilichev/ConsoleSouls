using System;
using JetBrains.Annotations;

namespace Common
{
    /// <inheritdoc />
    /// <summary>
    /// Used to log messages in simulator and unit test projects.
    /// Threadsafe.
    /// </summary>
    public sealed class ThreadSafeLogger : ILogger
    {
        [NotNull] private readonly object _lock = new object();
        [NotNull] private readonly ILogger _logger;

        public ThreadSafeLogger([NotNull] ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <inheritdoc />
        public void WriteError(string message)
        {
            lock (_lock) _logger.WriteError(message);
        }

        /// <inheritdoc />
        public void WriteWarning(string message)
        {
            lock (_lock) _logger.WriteWarning(message);
        }

        /// <inheritdoc />
        public void WriteInformation(string message)
        {
            lock (_lock) _logger.WriteInformation(message);
        }

        /// <inheritdoc />
        public void WriteDebugInformation(string message)
        {
            lock (_lock) _logger.WriteDebugInformation(message);
        }
    }
}
