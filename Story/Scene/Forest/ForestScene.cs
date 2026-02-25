using System;
using TextBaseGame.Interfaces;
using TextBaseGame.Players;

namespace TextBaseGame.Story.Scene
{
    public class ForestScene : BaseScene
    {
        private IFocusState<ForestScene> _currentFocus;

        public ForestScene()
        {
            _currentFocus = new ForestFocus();
        }
        public override string Name => "Scena 3 - Padurea " + _currentFocus.Name;
        public override string Description => _currentFocus.Description;

        public override string GetContextualHelp()
        {
            string focusHelp = "Comenzi: " + string.Join(", ", _currentFocus.AvailableCommands);
            return $"{focusHelp}\n{base.GetContextualHelp()}";
        }
        protected override void HandleCustomCommand(string input, Player player)
        {   /*
            if (input == "next")
            {
                Console.WriteLine("Ai traversat pădurea.");
                IsCompleted = true;
            }
            else
            {
                Console.WriteLine("Comandă invalidă.");
            }
            */
            _currentFocus.HandleCommand(input, player, this);
        }

        public void ChangeFocus(IFocusState<ForestScene> newFocus)
            {
                _currentFocus = newFocus;
        }
    }
}
