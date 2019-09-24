using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using Microsoft.Xna.Framework;

namespace ConsoleSouls
{
    internal class EnemyRoom : Room
    {
        private static readonly List<string> Look = Regex.Split(Res.Room, "\r\n|\r|\n").ToList();

        [NotNull] internal List<Enemy> Enemies { get; }

        private EnemyRoom([NotNull] Actor actor, char key, [NotNull] List<Enemy> enemies) : base(actor, key)
        {
            Enemies = enemies;
        }

        public override void OnUpdate(GameTime gameTime)
        {
            Actor.OnUpdate(gameTime);
            DrawEntrance();
        }
    
        [NotNull]
        internal static Room Create(int level, char key)
        {
            var actor = new Actor(Look)
            {
                Foreground = Color.Gray,
            };

            var rnd = new Random(DateTime.Now.Millisecond + 2345);
            var enemiesCount = rnd.Next(1, 4);

            var enemies = Enumerable
                .Range(1, enemiesCount)
                .ToList()
                .Select(arg => Enemy.Create(level))
                .ToList();

            return new EnemyRoom(actor, key, enemies);
        }
    }
}
