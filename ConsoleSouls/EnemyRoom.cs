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

        private EnemyRoom([NotNull] Actor actor) : base(actor)
        {

        }

        public override void OnUpdate(GameTime gameTime)
        {
            Actor.OnUpdate(gameTime);
        }


        [NotNull]
        internal static Room Create(int currentStage)
        {
            var actor = new Actor(Look);
            return new EnemyRoom(actor);
        }
    }
}
