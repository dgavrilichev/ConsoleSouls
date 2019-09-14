using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.Xna.Framework;

namespace ConsoleSouls
{
    internal sealed class Actor : IDrawContent
    {
        [NotNull] private List<string> _look;

        public Actor([NotNull] List<string> look)
        {
            _look = look ?? throw new ArgumentNullException(nameof(look));
        }

        internal Point Location { get; set; }
        internal Color Foreground { get; set; }
        internal Color Background { get; set; }

        public void OnUpdate(GameTime gameTime)
        {
            var console = SadConsole.Global.CurrentScreen;
            for (var y = 0; y < _look.Count; y++)
            {
                console.Print(Location.X, Location.Y + y, _look[y], Foreground, Background);
            }
        }
    }
}
