using System.Collections.Generic;
using TextBaseGame.Interfaces;
using TextBaseGame.Players;

namespace TextBaseGame.Story.Scene
{
    internal class ForestFocus : IFocusState<ForestScene>
    {
        private string actionText = "Te afli în mijlocul unei păduri. Poți vedea un copac bătrân, o stâncă acoperită de mușchi, o potecă care duce mai adânc în pădure și o poiană luminată de soare.";

        public string Name => "Pădure (privire în ansamblu)";

        public string Description => actionText;

        public IEnumerable<string> AvailableCommands 
        {
            get
            {
                yield return "go old tree";
                yield return "go rock";
                yield return "go path";
                yield return "go meadow";
            }
        }

        public void HandleCommand(string input, Player player, ForestScene scene)
        {
            switch (input)
            {
                case "go old tree":
                    scene.ChangeFocus(new OldTreeFocus());
                    break;
                case "go rock":
                    scene.ChangeFocus(new RockFocus());
                    break;
                case "go path":
                    scene.ChangeFocus(new PathFocus());
                    break;
                case "go meadow":
                    scene.ChangeFocus(new MeadowFocus());
                    break;
                default:
                    actionText = "Comanda necunoscută.";
                    break;
            }
        }
    }
}