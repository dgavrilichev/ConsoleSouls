using System;
using JetBrains.Annotations;
using Microsoft.Xna.Framework;

namespace ConsoleSouls
{
    internal abstract class Room : IDrawContent
    {
        [NotNull] private readonly Actor _actor;

        protected Room([NotNull] Actor actor)
        {
            _actor = actor ?? throw new ArgumentNullException(nameof(actor));
        }

        public void OnUpdate([NotNull] GameTime gameTime)
        {
            _actor.OnUpdate(gameTime);
        }
    }
}
