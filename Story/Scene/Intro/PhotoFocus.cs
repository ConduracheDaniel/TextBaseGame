using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBaseGame.Interfaces;

namespace TextBaseGame.Story.Scene.Intro
{
    internal class PhotoFocus : IFocusState<IntroScene>
    {
        private string actionText = "Te uiti la fotografie. Este o fotografie veche, în alb și negru";
        public string Name => "Fotografie";
        public string Description => actionText;
        public IEnumerable<string> AvailableCommands
        {
            get
            {
                yield return "look";
                yield return "back";
            }
        }
        public void HandleCommand(string input, Players.Player player, IntroScene scene)
        {
            switch (input)
            {
                case "look":
                    actionText = "Examinând fotografia mai atent, observi ca sunt 3 persoane";
                    break;
                case "back":
                    scene.ChangeFocus(new RoomFocus());
                    break;
                default:
                    actionText = "Comanda necunoscută.";
                    break;
            }
        }
    }
}
