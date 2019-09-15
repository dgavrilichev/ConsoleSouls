using System;
using JetBrains.Annotations;
using Microsoft.Xna.Framework;

namespace ConsoleSouls
{
    internal sealed class CrossRoad : IScene
    {
        private static readonly Point Room1Location = new Point(10, 5);
        private static readonly Point Room2Location = new Point(45, 5);
        private static readonly Point Room3Location = new Point(80, 5);

        [NotNull] internal Room Room1 { get; }
        [NotNull] internal Room Room2 { get; }
        [NotNull] internal Room Room3 { get; }

        public bool IsCompleted { get; }

        public void OnUpdate(GameTime gameTime)
        {
            Room1.OnUpdate(gameTime);
            Room2.OnUpdate(gameTime);
            Room3.OnUpdate(gameTime);
        }

        private CrossRoad([NotNull] Room room1, [NotNull] Room room2, [NotNull] Room room3)
        {
            Room1 = room1 ?? throw new ArgumentNullException(nameof(room1));
            Room2 = room2 ?? throw new ArgumentNullException(nameof(room2));
            Room3 = room3 ?? throw new ArgumentNullException(nameof(room3));
        }

        [NotNull]
        internal static CrossRoad Generate(int currentStage)
        {
            var room1 = EnemyRoom.Create(currentStage);
            room1.Location = Room1Location;

            var room2 = EnemyRoom.Create(currentStage);
            room1.Location = Room2Location;

            var room3 = EnemyRoom.Create(currentStage);
            room1.Location = Room3Location;

            return new CrossRoad(room1, room2, room3);
        }
    }
}
