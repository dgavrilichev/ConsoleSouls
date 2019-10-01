using System;
using System.Collections.Generic;
using ConsoleSouls.Skills;
using JetBrains.Annotations;

namespace ConsoleSouls
{
    internal sealed class Enemy
    {
        private readonly int _order;

        internal string Name { get; }
        internal int Level { get; set; }
        internal LevelValue<int> Health { get; set; }
        internal int Armor { get; set; }
        internal List<Skill> Skills { get; set; }

        private Enemy(string name, int order)
        {
            _order = order;
            Name = name;
        }
       
        [NotNull]
        internal static Enemy Create(int level, int order)
        {
            var randomValue = Rnd.Get(0, 2);

            Enemy enemy;
            switch (randomValue)
            {
                case 0:
                   enemy = new Enemy("Skeleton Swordsman", order);
                   enemy.Level = level;
                   enemy.Health = new LevelValue<int>(Rnd.Get(2 + level * 4, Math.Min(60, 7 + level * 5)));
                   enemy.Armor = Rnd.Get(0, enemy.Health.Maximum);

                   //Skills:
                   var baseDamage = Rnd.Get(1, level / 5 + 1);
                   var attack1 = new Skill("Sword slash", 8.0, 33.3, 66.6, new List<Effect>
                   {
                       new DirectDamageEffect(baseDamage, "Direct damage")
                   });
                   var attack2 = new Skill("Perfect strike", 4.0, 60, 80, new List<Effect>
                   {
                       new DirectDamageEffect(baseDamage * 2, "Direct damage")
                   });
                   var attack3 = new Skill("Merciful strike", 12.0, 30, 80, new List<Effect>
                   {
                       new DirectDamageEffect(1, "Direct damage")
                   });
                   enemy.Skills = new List<Skill>
                   {
                       attack1,
                       attack1,
                       attack1,
                       attack1,
                       attack2,
                       attack3,
                   };
                    break;

                case 1:
                    enemy = new Enemy("Bonehound", order);
                    enemy.Level = level;
                    enemy.Health = new LevelValue<int>(Rnd.Get(2 + level * 3, Math.Min(60, 5 + level * 4)));
                    enemy.Armor = Rnd.Get(0, enemy.Health.Maximum);

                    //Skills:
                    baseDamage = Rnd.Get(1, level / 8 + 1);
                    attack1 = new Skill("Claws", 4.0, 33.3, 66.6, new List<Effect>
                    {
                        new DirectDamageEffect(baseDamage, "Direct damage")
                    });
                    attack2 = new Skill("Bite", 9.0, 40, 80, new List<Effect>
                    {
                        new DirectDamageEffect(baseDamage * 3, "Direct damage")
                    });
                    attack3 = new Skill("Merciful strike", 12.0, 30, 80, new List<Effect>
                    {
                        new DirectDamageEffect(1, "Direct damage")
                    });
                    enemy.Skills = new List<Skill>
                    {
                        attack1,
                        attack1,
                        attack1,
                        attack1,
                        attack2,
                        attack2,
                        attack3,
                    };
                    break;

                case 2:
                    enemy = new Enemy("Dead Crow", order);
                    enemy.Level = level;
                    enemy.Health = new LevelValue<int>(Rnd.Get(2 + level * 2, Math.Min(60, 4 + level * 3)));
                    enemy.Armor = Rnd.Get(0, enemy.Health.Maximum);

                    //Skills:
                    baseDamage = Rnd.Get(1, level / 8 + 1);
                    attack1 = new Skill("Claws", 4.0, 33.3, 66.6, new List<Effect>
                    {
                        new DirectDamageEffect(baseDamage, "Direct damage")
                    });
                    attack2 = new Skill("Furious bite", 3.0, 40, 80, new List<Effect>
                    {
                        new DirectDamageEffect(baseDamage * 2, "Direct damage")
                    });
                    attack3 = new Skill("Merciful strike", 12.0, 30, 80, new List<Effect>
                    {
                        new DirectDamageEffect(1, "Direct damage")
                    });
                    enemy.Skills = new List<Skill>
                    {
                        attack1,
                        attack1,
                        attack1,
                        attack1,
                        attack2,
                        attack2,
                        attack3,
                    };
                    break;

                default:
                    throw new InvalidOperationException("Monster not implemented!");
            }

            return enemy;
        }
    }
}
