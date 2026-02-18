using System;
using TextBaseGame.Players;

namespace TextBaseGame.Story.Scene
{

    public class BridgeScene : BaseScene
    {
        public override string Name => "Scena 4 - Podul";
        public override string Description =>
            "Un pod fragil. Scrie 'next' pentru a traversa.";

        protected override void HandleCustomCommand(string input, Player player)
        {
            if (input == "next")
            {
                Console.WriteLine("Ai trecut podul.");
                IsCompleted = true;
            }
            else
            {
                Console.WriteLine("Comandă invalidă.");
            }
        }
    }

}
