namespace ConsoleSouls
{
    internal sealed class Player
    {
        internal LevelValue<int> Health { get; set; } = new LevelValue<int>(10);
        internal int Experience { get; set; }
        internal int Level { get; } = 1;
    }
}
