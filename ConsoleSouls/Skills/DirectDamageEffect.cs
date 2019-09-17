namespace ConsoleSouls.Skills
{
    internal class DirectDamageEffect : Effect
    {
        public DirectDamageEffect(int minDamage, int maxDamage, EffectSource source, string name) : base(name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Source = source;
        }

        internal int MinDamage { get; }
        internal int MaxDamage { get; }
        internal EffectSource Source { get; }
    }
}
