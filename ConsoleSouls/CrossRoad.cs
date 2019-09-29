using System;
using System.Linq;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using SadConsole;

namespace ConsoleSouls
{
    internal sealed class CrossRoad : IScene
    {
        private static readonly Actor Title = new Actor(Regex.Split(Res.CrossRoadTitle, "\r\n|\r|\n").ToList());

        private static readonly Point Room1Location = new Point(11, 7);
        private static readonly Point Room2Location = new Point(49, 7);
        private static readonly Point Room3Location = new Point(87, 7);

        private bool _roomInteraction;

        [NotNull] internal Room Room1 { get; }
        [NotNull] internal Room Room2 { get; }
        [NotNull] internal Room Room3 { get; }

        public bool IsCompleted { get; private set; }

        static CrossRoad()
        {
            Title.Foreground = Color.Gold;
            Title.Location = new Point(14, 0);
        }

        private CrossRoad([NotNull] Room room1, [NotNull] Room room2, [NotNull] Room room3)
        {
            Room1 = room1 ?? throw new ArgumentNullException(nameof(room1));
            Room2 = room2 ?? throw new ArgumentNullException(nameof(room2));
            Room3 = room3 ?? throw new ArgumentNullException(nameof(room3));
        }

        public void OnUpdate(GameTime gameTime)
        {
            Room1.OnUpdate(gameTime);
            Room2.OnUpdate(gameTime);
            Room3.OnUpdate(gameTime);

            Title.OnUpdate(gameTime);

            ProcessInput();
        }

        private void ProcessInput()
        {
            Room selectedRoom = null;
            if (Global.KeyboardState.IsKeyPressed(Keys.NumPad1))
                selectedRoom = Room1;
            if (Global.KeyboardState.IsKeyPressed(Keys.NumPad2))
                selectedRoom = Room2;
            if (Global.KeyboardState.IsKeyPressed(Keys.NumPad3))
                selectedRoom = Room2;

            if (selectedRoom != null)
                InteractWithRoom(selectedRoom);
        }

        private void InteractWithRoom(Room selectedRoom)
        {
            _roomInteraction = true;
            selectedRoom.Interact();
        }

        [NotNull]
        internal static CrossRoad Generate(int currentStage, [NotNull] Player player)
        {
            if(player == null) throw new ArgumentNullException(nameof(player));

            var room1 = EnemyRoom.Create(currentStage, '1', player);
            room1.Location = Room1Location;
            
            var room2 = EnemyRoom.Create(currentStage, '2', player);
            room2.Location = Room2Location;

            var room3 = EnemyRoom.Create(currentStage, '3', player);
            room3.Location = Room3Location;

            return new CrossRoad(room1, room2, room3);
        }
    }
}
