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

        private EnemyRoom([NotNull] Actor actor, char key) : base(actor, key)
        {

        }

        public override void OnUpdate(GameTime gameTime)
        {
            Actor.OnUpdate(gameTime);
            DrawEntrance();
        }
    
        [NotNull]
        internal static Room Create(int currentStage, char key)
        {
            var actor = new Actor(Look)
            {
                Foreground = Color.Gray,
            };
            return new EnemyRoom(actor, key);
        }
    }
}
