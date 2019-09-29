namespace ConsoleSouls
{
    internal sealed class Player
    {
        internal LevelValue<int> Health { get; set; } = new LevelValue<int>(50);
        internal LevelValue<int> Mana { get; set; } = new LevelValue<int>(50);
        internal LevelValue<int> Stamina { get; set; } = new LevelValue<int>(50);
        internal int Experience { get; set; }
        internal int Level { get; } = 1;
    }
}
