using System;
using TextBaseGame.Players;

namespace TextBaseGame.Story.Scene
{
    public class IntroScene : BaseScene
    {
        public override string Name => "Scena 1 - Camera întunecată";
        private string  actionText = "Te trezești într-o cameră. Vezi o cheie pe masă. Scrie 'look' pentru a examina.";
        private bool isKeyVisible = false;
        public override string Description
        {
            get
            {
                return actionText;
            }
        }
            

        protected override void HandleCustomCommand(string input, Player player)
        {
            switch (input)
            {
                case "look":
                    if (player.Inventory.Contains("cheie"))
                    {
                        actionText = "Te uiți în jur, dar nu mai vezi nimic util.";
                    }
                    else
                    {
                        isKeyVisible = true;
                        actionText = "Poți să o iei cheia cu comanda 'take'.";
                    }
                    break;
                case "take":
                    if (player.Inventory.Contains("cheie"))
                    {
                        actionText = "Ai deja cheia.";
                    }
                    else if (isKeyVisible)
                    {
                        player.AddItem("cheie");
                        actionText = "Ai luat cheia. Poti sa treci mai departe folosind comanda 'next";
                    }
                    break;
                case "next":
                    actionText = "Daca nu ai cheia mai arunca o privire";
                    if(player.Inventory.Contains("cheie"))
                        IsCompleted = true;
                    break;
                default:
                    actionText = "Comandă invalidă.";
                    break;
            }
           
        }
    }
}
