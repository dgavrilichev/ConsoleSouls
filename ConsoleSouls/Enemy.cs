namespace ConsoleSouls
{
    internal sealed class Enemy
    {
        internal string Name { get; set; } = "Generic Monster";
        internal LevelValue<int> Health { get; set; } = new LevelValue<int>(100, 100);
    }
}
