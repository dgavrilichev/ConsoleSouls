using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Microsoft.Xna.Framework;
using SharpDX;
using Color = Microsoft.Xna.Framework.Color;
using Point = Microsoft.Xna.Framework.Point;

namespace ConsoleSouls
{
    internal sealed class Actor : IDrawContent
    {
        [NotNull] private readonly List<string> _look;

        public Actor([NotNull] List<string> look)
        {
            _look = look ?? throw new ArgumentNullException(nameof(look));
            Size = new Size2(_look.Max().Length, _look.Count);
        }

        internal Size2 Size { get; }

        internal Point Location { get; set; } = new Point(0, 0);
        internal Color Foreground { get; set; } = Color.White;
        internal Color Background { get; set; } = Color.Black;

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
