namespace ConsoleSouls
{
    internal sealed class LevelValue<T>
    {
        public LevelValue(T current, T maximum)
        {
            Current = current;
            Maximum = maximum;
        }

        internal T Current { get; set; }
        internal T Maximum { get; set; }
    }
}
