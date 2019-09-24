using System.Collections.Generic;

namespace ConsoleSouls.Skills
{
    internal sealed class Skill
    {
        public Skill(string name, double castTime, double charge1Percent, double charge2Percent, List<Effect> effects)
        {
            Name = name;
            CastTime = castTime;
            Charge1Percent = charge1Percent;
            Charge2Percent = charge2Percent;
            Effects = effects;
        }

        internal string Name { get; }
        internal double CastTime { get; }
        internal double Charge1Percent { get; }
        internal double Charge2Percent { get; }
        internal List<Effect> Effects { get; }
    }
}
