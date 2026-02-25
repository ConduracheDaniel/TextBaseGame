using System.Collections.Generic;
using TextBaseGame.Interfaces;

namespace TextBaseGame.Story.Scene
{
    internal class MeadowFocus : IFocusState<ForestScene>
    {
        private string actionText = "Te afli într-o poiană luminată de soare. Poti vedea o casa si un râu";
        public string Name => "Poiană";
        public string Description => actionText;
        public IEnumerable<string> AvailableCommands
        {
            get
            {
                yield return "go house";
                yield return "go river";
     
            }
        }

        public void HandleCommand(string input, Players.Player player, ForestScene scene)
        {
            switch (input)
            {
                case "go house":
                    scene.ChangeFocus(new HouseFocus());
                    break;
                case "go river":
                    scene.ChangeFocus(new RiverFocus());
                    break;
                default:
                    actionText = "Comanda necunoscută.";
                    break;
            }
        }
    }
}