using System;
using JetBrains.Annotations;
using Microsoft.Xna.Framework;

namespace ConsoleSouls
{
    internal sealed class CrossRoad : IDrawContent
    {
        [NotNull] internal Room Room1 { get; }
        [NotNull] internal Room Room2 { get; }
        [NotNull] internal Room Room3 { get; }

        public void OnUpdate(GameTime gameTime)
        {
            Room1.OnUpdate(gameTime);
            Room2.OnUpdate(gameTime);
            Room3.OnUpdate(gameTime);
        }

        private CrossRoad([NotNull] Room room1, [NotNull] Room room2, [NotNull] Room room3)
        {
            Room1 = room1 ?? throw new ArgumentNullException(nameof(room1));
            Room2 = room2 ?? throw new ArgumentNullException(nameof(room2));
            Room3 = room3 ?? throw new ArgumentNullException(nameof(room3));
        }
    }
}
