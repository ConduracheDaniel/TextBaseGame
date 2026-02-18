using System;
using TextBaseGame.Players;

namespace TextBaseGame.Story.Scene
{
    public class IntroScene : BaseScene
    {
        public override string Name => "Scena 1 - Camera întunecată";
        public override string Description
        {
            get
            {
                return "Te trezești într-o cameră. Vezi o cheie pe masă. Scrie 'look' pentru a examina.";
            }
        }
            

        protected override void HandleCustomCommand(string input, Player player)
        {
            switch (input)
            {
                case "look":
                     "Ai vazut o cheie.";
                    break;
                case "take":
                    Console.WriteLine("Ai luat cheia de pe masa");
                    player.AddItem("cheie");
                    IsCompleted = true;
                    break;
                default:
                    Console.WriteLine("Comandă invalidă.");
                    break;
            }
           
        }
    }
}
