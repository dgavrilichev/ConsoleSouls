using System;

namespace Common
{
    /// <inheritdoc />
    /// <summary>
    /// Used to log messages in simulator and unit test projects.
    /// </summary>
    public sealed class ConsoleLogger : ILogger
    {
        /// <inheritdoc />
        public void WriteError(string message)
        {
            WriteDateTime();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /// <inheritdoc />
        public void WriteWarning(string message)
        {
            WriteDateTime();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /// <inheritdoc />
        public void WriteInformation(string message)
        {
            WriteDateTime();
            Console.WriteLine(message);
        }

        public void WriteDebugInformation(string message)
        {
            WriteDateTime();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("[DEBUG] ");
            Console.ResetColor();
            Console.WriteLine(message);
        }

        private static void WriteDateTime()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"[{DateTime.UtcNow:HH:mm:ss.fff}] ");
            Console.ResetColor();
        }
    }
}
