using System;
using System.Collections.Generic;
using TextBaseGame.Interfaces;
using TextBaseGame.Players;

namespace TextBaseGame.Story.Scene.Intro
{
    internal class PaintingFocus : IFocusState
    {
        private string actionText = "Te uiti la pictura. Scrie 'look' pentru a examina pictura mai atent.";
        public string Name => "Pictura misterioasa";
        public string Description => actionText;

        public IEnumerable<string> AvailableCommands
        {
            get
            {
                yield return "look";
                yield return "back";
            }
        }

        public void HandleCommand(string input, Player player, IntroScene scene)
        {
            switch (input)
            {
                case "look":
                    actionText = "Observi in spatele picturii cifra 1";
                    break;
                case "back":
                    scene.ChangeFocus(new RoomFocus());
                    break;
                default:
                    actionText = "Comanda necunoscuta.";
                    break;
            }
        }
    }
}
