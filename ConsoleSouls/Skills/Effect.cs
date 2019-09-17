namespace ConsoleSouls.Skills
{
    internal abstract class Effect
    {
        protected Effect(string name)
        {
            Name = name;
        }

        internal string Name { get; }
    }
}
