namespace ConsoleSouls
{
    internal sealed class LevelValue<T>
    {
        public LevelValue(T maximum)
        {
            Current = maximum;
            Maximum = maximum;
        }

        internal T Current { get; set; }
        internal T Maximum { get; set; }
    }
}
