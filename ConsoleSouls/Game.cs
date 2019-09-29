using JetBrains.Annotations;
using Microsoft.Xna.Framework;
using SadConsole;

namespace ConsoleSouls
{
    internal class Game : IDrawContent
    {
        [NotNull] private readonly Player _player;
        private int _currentStage = 1;
        private IScene _currentScene;

        internal Game()
        {
            _player = new Player();
            _currentScene = CrossRoad.Generate(_currentStage, _player);
        }

        public void OnUpdate([NotNull] GameTime gameTime)
        {
            Global.CurrentScreen.Clear();

            if (!_currentScene.IsCompleted)
                _currentScene.OnUpdate(gameTime);
            else
            {
                _currentScene = CrossRoad.Generate(_currentStage++, _player);
            }
        }
    }
}
