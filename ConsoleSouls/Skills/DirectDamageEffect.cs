namespace ConsoleSouls.Skills
{
    internal class DirectDamageEffect : Effect
    {
        public DirectDamageEffect(int damage, string name) : base(name)
        {
            Damage = damage;
        }

        internal int Damage { get; }
    }
}