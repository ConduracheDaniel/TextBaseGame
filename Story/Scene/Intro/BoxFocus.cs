using System;
using System.Collections;
using System.Collections.Generic;
using TextBaseGame.Interfaces;
using TextBaseGame.Players;

namespace TextBaseGame.Story.Scene.Intro
{
    internal class BoxFocus : IFocusState<IntroScene>
    {
        private bool isKeyVisible = false;
        private bool isBoxOpened = false;
        private string actionText = "Te uiti la cutie. Este o cutie veche de lemn, cu un lacăt ruginit. Poți încerca să o deschizi sau să o examinezi mai atent.";
        public string Name => "Cutie";

        public IEnumerable<string> AvailableCommands
        {
            get
            {
                yield return "look";
                yield return "take";
                yield return "open ###";
                yield return "back";
            }
        }
        public string Description => actionText;
      
        public void HandleCommand(string input, Player player, IntroScene scene)
        {
            switch (input)
            {
                case "look":
                    if (isBoxOpened)
                    {
                        isKeyVisible = true;
                        if (isKeyVisible)
                        {
                            actionText = "Cutia este deschisă. În interior, vezi o cheie strălucitoare.\nScrie 'take' pentru a o lua";
                        }
                        else
                        {
                            actionText = "Cutia este deschisă, dar nu vezi nimic de interes în interior.";

                        }
                    }
                    else 
                    {
                        actionText = "Cutia este inchisa. Poti incerca sa o deschizi cu 'open ###'.";
                    }
                        break;
                case "take":
                    if (player.Inventory.Contains("key"))
                    {
                        actionText = "Ai deja cheia în inventar.";
                    }
                    else if (isKeyVisible)
                    {
                        player.AddItem("key");
                        actionText = "Ai luat cheia și ai adăugat-o în inventar.";
                        isKeyVisible = false;
                    }
                    break;
                case "back":
                    scene.ChangeFocus(new RoomFocus());
                    break;
                case "open 123":
                    if (isBoxOpened)
                    {
                        actionText = "Cutia este deja deschisă.";
                    }
                    else
                    {
                        isBoxOpened = true;
                        actionText = "Ai deschis cutia. Scrie 'look' sa vezi ce e in ea.";
                    }
                    break;
                default:
                    actionText = "Comandă necunoscută";
                    break;

            }
        }
    }
}
