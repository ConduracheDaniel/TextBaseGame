using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBaseGame.Interfaces;

namespace TextBaseGame.Story.Scene.Intro
{
    internal class CarpetFocus : IFocusState<IntroScene>
    {
        private string actionText = "Te uiti la covor. Este un covor vechi, cu un model complicat. Poți încerca să îl examinezi mai atent sau să te întorci la privirea de ansamblu.";
        public string Name => "Covor";
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
                    actionText = "Examinând covorul mai atent, observi un model care pare să formeze o cifră. Este cifra 2.";
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
