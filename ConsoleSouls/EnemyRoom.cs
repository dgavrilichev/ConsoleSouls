using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using Microsoft.Xna.Framework;
using SadConsole;

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
            DrawEnemies();
        }

        [NotNull]
        internal static Room Create(int level, char key)
        {
            var actor = new Actor(Look)
            {
                Foreground = Color.Gray,
            };

            var enemiesCount = Rnd.Get(1, 3);

            var enemies = Enumerable
                .Range(1, enemiesCount)
                .ToList()
                .Select(arg => Enemy.Create(level))
                .ToList();

            return new EnemyRoom(actor, key, enemies);
        }

        private void DrawEnemies()
        {
            var console = Global.CurrentScreen;
            var (x, y) = new Point(Location.X, Location.Y + Actor.Size.Height + 4);


            console.Print(x + 8, y, "Enemies:", Color.DarkRed);

            for (var index = 0; index < Enemies.Count; index++)
            {
                var enemy = Enemies[index];
                console.Print(x, y + index + 1, $"{index + 1}) {enemy.Name}", Color.DarkRed);
            }
        }
    }
}
