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

            var enemies = new List<Enemy>();
            for (var enemyIndex = 1; enemyIndex <= enemiesCount; enemyIndex++)
            {
                enemies.Add(Enemy.Create(level, enemyIndex));
            }

            return new EnemyRoom(actor, key, enemies);
        }

        private void DrawEnemies()
        {
            var console = Global.CurrentScreen;
            var (x, y) = new Point(Location.X , Location.Y + Actor.Size.Height + 3);

            console.Print(x, y, "Enemies:", Color.DarkRed);

            for (var index = 0; index < Enemies.Count; index++)
            {
                var enemy = Enemies[index];
                console.Print(x, y + index + 1, $"{index + 1})", Color.DarkRed);
                console.Print(x + 3, y + index + 1, enemy.Name, new Color(210, 20, 20));
            }
        }
    }
}
