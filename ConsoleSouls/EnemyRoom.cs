using JetBrains.Annotations;
using Microsoft.Xna.Framework;

namespace ConsoleSouls
{
    internal class EnemyRoom : Room
    {
        public EnemyRoom([NotNull] Actor actor) : base(actor)
        {

        }

        public override void OnUpdate(GameTime gameTime)
        {
            Actor.OnUpdate(gameTime);
        }
    }
}
