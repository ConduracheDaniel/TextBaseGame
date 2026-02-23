using System;
using TextBaseGame.Players;

namespace TextBaseGame.Story.Scene
{
    public class EscapeRoomScene : BaseScene
    {
        private string actionText = "Există o ușă încuiată. Scrie 'next' pentru a încerca să o deschizi.";
        public override string Name => "Scena 2 - Ușa încuiată";
        public override string Description => actionText;


        protected override void HandleCustomCommand(string input, Player player)
        {
            if (input == "next")
            {
                if (player.Inventory.Contains("key"))
                {
                    actionText = "Ai folosit cheia pentru a deschide ușa. Felicitări, ai scăpat din cameră!";
                    player.RemoveItem("key");
                    IsCompleted = true;
                }
                else
                {
                    actionText = "Nu ai cheia pentru a deschide usa.";
                }
            }
            else
            {
                actionText = "Comanda necunoscută.";
            }
        }
    }
}
