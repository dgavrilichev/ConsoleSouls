using System;
using JetBrains.Annotations;
using Microsoft.Xna.Framework;
using SadConsole;

namespace ConsoleSouls
{
    internal sealed class ProgressBar : IDrawContent
    {
        private const int Light = 176;
        private const int Medium = 177;
        private const int Full = 178;

        [NotNull] private readonly LevelValue<double> _value;
        private readonly Point _position;
        private readonly int _width;
        private readonly Color _color;

        internal ProgressBar([NotNull] LevelValue<double> value, Point position, int width, Color color)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
            _position = position;
            _width = width;
            _color = color;
        }

        public void OnUpdate(GameTime gameTime)
        {
            var points = _width /_value.Maximum * _value.Current;
            var integerPoints = Convert.ToInt32(Math.Truncate(points));
            var decimalPart = points - integerPoints;

            var symbol = 32;
            if (decimalPart > 0.8)
                symbol = Full;
            else if (decimalPart > 0.46)
                symbol = Medium;
            else if (decimalPart > 0.13)
                symbol = Light;

            var console = Global.CurrentScreen;

            for (var index = 0; index < integerPoints; index++)           
                console.SetGlyph(_position.X + index, _position.Y, Full, _color);
           
            console.SetGlyph(_position.X + integerPoints, _position.Y, symbol, _color);
        }
    }
}
