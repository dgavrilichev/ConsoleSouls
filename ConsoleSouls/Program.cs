namespace ConsoleSouls
{
    internal static class Program
    {
        private const int Width = 128;
        private const int Height = 52;

        private static void Main()
        {
            // Setup the engine and create the main window.
            SadConsole.Game.Create(Width, Height);

            // Hook the start event so we can add consoles to the system.
            SadConsole.Game.OnInitialize = Init;

            // Start the game.
            SadConsole.Game.Instance.Run();
            SadConsole.Game.Instance.Dispose();
        }

        private static void Init()
        {
            var game = new Game();
            SadConsole.Game.OnUpdate = game.OnUpdate;
        }
    }
}
