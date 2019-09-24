using System;

namespace ConsoleSouls
{
    internal static class Rnd
    {
        private static readonly object Lock = new object();
        private static readonly Random Random = new Random(DateTime.Now.Millisecond / DateTime.Now.Second);

        internal static int Get(int min, int max)
        {
            lock (Lock) return Random.Next(min, max + 1);
        }
    }
}
