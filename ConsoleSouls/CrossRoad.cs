using Microsoft.Xna.Framework;

namespace ConsoleSouls
{
    internal sealed class CrossRoad : IDrawContent
    {
        internal Room Room1 { get; set; }
        internal Room Room2 { get; set; }
        internal Room Room3 { get; set; }

        public void OnUpdate(GameTime gameTime)
        {
            Room1.OnUpdate(gameTime);
            Room2.OnUpdate(gameTime);
            Room3.OnUpdate(gameTime);
        }
    }
}
