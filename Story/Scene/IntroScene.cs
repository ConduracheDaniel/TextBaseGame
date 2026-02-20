using System;
using TextBaseGame.Players;

namespace TextBaseGame.Story.Scene
{
    public class IntroScene : BaseScene
    {
        public override string Name => "Scena 1 - Camera întunecată";
        private string  actionText = "Te trezești într-o cameră. Vezi o cutie pe masă. Scrie 'look' pentru a examina.";
        private bool isKeyVisible = false;
        private bool isBoxOpened = false;
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
                    actionText = "Te uiti la cutie, scrie 'open' pentru a o deschide.";
                    if(isBoxOpened)
                    {
                        isKeyVisible = true;
                        if (isKeyVisible)
                        {
                            actionText = "Cutia este deschisă și vezi o cheie înăuntru. Poți să o iei cu comanda 'take'.";
                        }
                        else
                        {
                            actionText = "Cutia este deschisă, dar nu găsești nimic util.";
                        }
                    }
                    break;
                case "open":
                    isBoxOpened = true;
                    actionText = "Deschizi cutia, scrie 'look' sa vezi ce e in ea";
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
                        isKeyVisible = false;
                    }
                    else if (!isKeyVisible)
                    {
                        actionText = "Nu găsești nicio cheie de luat.";
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
