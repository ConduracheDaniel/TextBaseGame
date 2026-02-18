using System;
using TextBaseGame.Players;

namespace TextBaseGame.Story.Scene
{
    public class FinalScene : BaseScene
    {
        public override string Name => "Scena 6 - Sala Tronului";
        public override string Description =>
            "Ai ajuns în sala tronului. Scrie 'next' pentru a finaliza jocul.";

        protected override void HandleCustomCommand(string input, Player player)
        {
            if (input == "next")
            {
                Console.WriteLine("Ai câștigat jocul!");
                IsCompleted = true;
            }
            else
            {
                Console.WriteLine("Comandă invalidă.");
            }
        }
    }
}
