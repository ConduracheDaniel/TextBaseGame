using System;
using TextBaseGame.Players;

namespace TextBaseGame.Story.Scene
{
    public class CastleGateScene : BaseScene
    {
        public override string Name => "Scena 5 - Poarta Castelului";
        public override string Description =>
            "Ajungi la poarta castelului. Scrie 'next' pentru a intra.";

        protected override void HandleCustomCommand(string input, Player player)
        {
            if (input == "next")
            {
                Console.WriteLine("Ai intrat în castel.");
                IsCompleted = true;
            }
            else
            {
                Console.WriteLine("Comandă invalidă.");
            }
        }
    }
}
