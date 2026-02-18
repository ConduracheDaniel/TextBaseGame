using System;
using TextBaseGame.Players;

namespace TextBaseGame.Story.Scene
{
    public class ForestScene : BaseScene
    {
        public override string Name => "Scena 3 - Pădurea";
        public override string Description =>
            "Te afli într-o pădure. Scrie 'next' pentru a continua.";

        protected override void HandleCustomCommand(string input, Player player)
        {
            if (input == "next")
            {
                Console.WriteLine("Ai traversat pădurea.");
                IsCompleted = true;
            }
            else
            {
                Console.WriteLine("Comandă invalidă.");
            }
        }
    }
}
