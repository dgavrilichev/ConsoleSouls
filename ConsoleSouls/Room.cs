using System;
using JetBrains.Annotations;
using Microsoft.Xna.Framework;

namespace ConsoleSouls
{
    internal abstract class Room : IDrawContent
    {
        [NotNull] protected readonly Actor Actor;

        protected Room([NotNull] Actor actor)
        {
            Actor = actor ?? throw new ArgumentNullException(nameof(actor));
        }

        public abstract void OnUpdate([NotNull] GameTime gameTime);
    }
}
