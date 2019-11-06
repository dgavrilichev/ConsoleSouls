namespace Common
{
    /// <summary>
    /// Used to write messages.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Writes error message.
        /// Use it in case of error that prevents normal work.
        /// </summary>
        void WriteError(string message);

        /// <summary>
        /// Writes warning message.
        /// Use it when system meets expected error or result
        /// that should be noticed by administrator.
        /// </summary>
        void WriteWarning(string message);

        /// <summary>
        /// Writes information message.
        /// </summary>
        void WriteInformation(string message);

        /// <summary>
        /// Writes message related to debug.
        /// Should not be written in system log in production.
        /// </summary>
        void WriteDebugInformation(string message);
    }
}
