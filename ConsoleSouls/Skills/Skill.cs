using System.Collections.Generic;

namespace ConsoleSouls.Skills
{
    internal sealed class Skill
    {
        internal string Name { get; }
        internal double CastTime { get; }
        internal double Charge1Percent { get; }
        internal double Charge2Percent { get; }
        internal List<Effect> Effects { get; }
    }
}
