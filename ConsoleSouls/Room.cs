using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace ConsoleSouls
{
    internal sealed class Room
    {
        private List<string> _look;

        internal Point Location { get; set; }

        internal void OnUpdate(GameTime gameTime)
        {
            for (var y = 0; y < _look.Count; y++)
            {
                
            }
        }
    }
}
