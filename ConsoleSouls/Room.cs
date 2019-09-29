using System;
using JetBrains.Annotations;
using Microsoft.Xna.Framework;
using SadConsole;

namespace ConsoleSouls
{
    internal abstract class Room : IDrawContent
    {
        [NotNull] protected readonly Actor Actor;
        private readonly char _entranceKey;

        internal Point Location
        {
            get => Actor.Location;
            set => Actor.Location = value;
        }

        protected Room([NotNull] Actor actor, char entranceKey)
        {
            Actor = actor ?? throw new ArgumentNullException(nameof(actor));
            _entranceKey = entranceKey;
        }

        internal void DrawEntrance()
        {
            var console = Global.CurrentScreen;
            var (x, y) = new Point(Location.X + 8, Location.Y + Actor.Size.Height + 1);

            console.Print(x, y, "Enter room [", Color.White);
            console.SetGlyph(x + 12, y, _entranceKey, Color.Cyan);
            console.Print(x + 13, y, "]", Color.White);
        }

        public abstract void OnUpdate([NotNull] GameTime gameTime);
        public abstract void Interact();
    }
}
