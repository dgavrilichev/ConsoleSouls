using System;
using System.Threading;
using System.Threading.Tasks;
using Common;
using JetBrains.Annotations;
using LineageServerCommon;

namespace LineageServerConsole
{
    internal sealed class Simulator
    {
        private readonly ILogger _logger = new ThreadSafeLogger(new ConsoleLogger());

        private enum ProgramState
        {
            Running,
            Stopped
        }

        private ProgramState _currentState = ProgramState.Running;

        internal void Start()
        {
            using (var simulatorCancellation = new CancellationTokenSource())
            using (var main = new ServerMain(_logger))
            {
                while (!simulatorCancellation.IsCancellationRequested)
                {
                    using (var mainCancellation = new CancellationTokenSource())
                    {
                        StartAsync(main, simulatorCancellation.Token, mainCancellation.Token);
                        ShowKeyPressRequest();

                        var runRequested = false;
                        while (!simulatorCancellation.IsCancellationRequested && !runRequested)
                        {
                            var keyPressed = Console.ReadKey(true).Key;
                            switch (keyPressed)
                            {
                                case ConsoleKey.S:
                                    if (_currentState == ProgramState.Running)
                                    {
                                        mainCancellation.Cancel();
                                        _currentState = ProgramState.Stopped;
                                        ShowKeyPressRequest();
                                    }
                                    break;
                                case ConsoleKey.R:
                                    if (_currentState == ProgramState.Stopped)
                                    {
                                        _currentState = ProgramState.Running;
                                        runRequested = true;
                                    }
                                    break;
                                case ConsoleKey.Q:
                                    mainCancellation.Cancel();
                                    simulatorCancellation.Cancel();
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private async void StartAsync([NotNull] ServerMain main, CancellationToken simulatorToken, CancellationToken mainToken)
        {
            if (main == null) throw new ArgumentNullException(nameof(main));

            while (!simulatorToken.IsCancellationRequested && !mainToken.IsCancellationRequested)
            {
                try
                {
                    await main.StartAsync(mainToken);
                }
                catch (Exception e)
                {
                    _logger.WriteError(e.ToString());
                    _logger.WriteWarning("Sleep 10 seconds before restart..");
                    await Task.Delay(TimeSpan.FromSeconds(10), simulatorToken);
                }

                if (!mainToken.IsCancellationRequested)
                    _logger.WriteWarning("Restarting simulator..");
            }
        }

        private void ShowKeyPressRequest()
        {
            switch (_currentState)
            {
                case ProgramState.Running:
                    Console.Write("Press [S] to stop.");
                    break;
                case ProgramState.Stopped:
                    Console.Write("Press [R] to start.");
                    break;
                default:
                    throw new InvalidOperationException("Unexpected enum value!");
            }

            Console.WriteLine(" Press [Q] to close simulator.");
        }
    }
}
