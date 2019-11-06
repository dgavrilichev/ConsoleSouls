using JetBrains.Annotations;

namespace LineageServerConsole
{
    [UsedImplicitly]
    internal class Program
    {
        private static void Main()
        {
            var simulator = new Simulator();
            simulator.Start();
        }
    }
}
