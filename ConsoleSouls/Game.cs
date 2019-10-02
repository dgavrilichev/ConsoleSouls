using System;
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

        private ProgressBar _testBar;
        private ProgressBar _testBar2;
        private ProgressBar _testBar3;
        private ProgressBar _testBar4;
        private LevelValue<double> _testValue;

        internal Game()
        {
            _player = new Player();
            _currentScene = CrossRoad.Generate(_currentStage, _player);

            _testValue = new LevelValue<double>(1000);
            _testValue.Current = 0;
            _testBar4 = new ProgressBar(_testValue, new Point(10, 51), 90, Color.WhiteSmoke);
            _testBar = new ProgressBar(_testValue, new Point(10, 45), 10, Color.BlueViolet);
            _testBar2 = new ProgressBar(_testValue, new Point(10, 47), 20, Color.RosyBrown);
            _testBar3 = new ProgressBar(_testValue, new Point(10, 49), 60, Color.GreenYellow);
        }

        public void OnUpdate([NotNull] GameTime gameTime)
        {
            Global.CurrentScreen.Clear();

            _testValue.Current += 5;
            _testBar.OnUpdate(gameTime);
            _testBar2.OnUpdate(gameTime);
            _testBar3.OnUpdate(gameTime);
            _testBar4.OnUpdate(gameTime);

            if (Math.Abs(_testValue.Current - _testValue.Maximum) < 0.0001)
                _testValue.Current = 0;

            if (!_currentScene.IsCompleted)
                _currentScene.OnUpdate(gameTime);
            else           
                _currentScene = CrossRoad.Generate(_currentStage++, _player);
         }
    }
}
