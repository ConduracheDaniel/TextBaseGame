using System;
using TextBaseGame.Players;

namespace TextBaseGame.Story.Scene
{
    public class EscapeRoomScene : BaseScene
    {
        public override string Name => "Scena 2 - Ușa încuiată";
        public override string Description =>
            "Există o ușă încuiată. Scrie 'next' pentru a încerca să o deschizi.";

        protected override void HandleCustomCommand(string input, Player player)
        {
            if (input == "next")
            {
                if (player.Inventory.Contains("cheie"))
                {
                    Console.WriteLine("Ai deschis ușa!");
                    player.RemoveItem("cheie");
                    IsCompleted = true;
                }
                else
                {
                    Console.WriteLine("Nu ai cheia.");
                }
            }
            else
            {
                Console.WriteLine("Comandă invalidă.");
            }
        }
    }
}
