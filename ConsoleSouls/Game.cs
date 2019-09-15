using System.Text;
using JetBrains.Annotations;
using Microsoft.Xna.Framework;

namespace ConsoleSouls
{
    internal class Game : IDrawContent
    {
        private int _currentStage = 1;
        private IScene _currentScene;

        internal Game()
        {
            _currentScene = CrossRoad.Generate(_currentStage);
        }

        public void OnUpdate([NotNull] GameTime gameTime)
        {
            if (!_currentScene.IsCompleted)
                _currentScene.OnUpdate(gameTime);
        }
    }
}
