using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.Xna.Framework;

namespace ConsoleSouls
{
    internal sealed class Combat : IDrawContent
    {
        [NotNull] private readonly Player _player;
        [NotNull] private readonly List<Enemy> _enemies;

        internal Combat([NotNull] Player player, [NotNull] List<Enemy> enemies)
        {
            _player = player ?? throw new ArgumentNullException(nameof(player));
            _enemies = enemies ?? throw new ArgumentNullException(nameof(enemies));
        }

        public void OnUpdate(GameTime gameTime)
        {
            throw new System.NotImplementedException();
        }
    }
}
