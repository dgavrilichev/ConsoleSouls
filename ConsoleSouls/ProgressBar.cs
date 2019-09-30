using JetBrains.Annotations;
using Microsoft.Xna.Framework;

namespace ConsoleSouls
{
    internal sealed class ProgressBar : IDrawContent
    {
        [NotNull] private readonly LevelValue<int> _value;

        internal ProgressBar([NotNull] LevelValue<int> value)
        {
            _value = value;
        }

        public void OnUpdate(GameTime gameTime)
        {
            
        }
    }
}
