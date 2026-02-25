using System;
using TextBaseGame.Interfaces;
using TextBaseGame.Players;
using TextBaseGame.Story.Scene.Intro;

namespace TextBaseGame.Story.Scene
{
    public class IntroScene : BaseScene
    {
        private IFocusState<IntroScene> _currentFocus;
        
        public IntroScene()
        {
            _currentFocus = new RoomFocus();
     
        }

        public override string Name => "Scena 1 - Camera întunecată "+_currentFocus.Name ;
        public override string Description => _currentFocus.Description;
        
        public override string GetContextualHelp()
        {
            string focusHelp = "Comenzi: " + string.Join(", ", _currentFocus.AvailableCommands);
            return $"{focusHelp}\n{base.GetContextualHelp()}";
        }
        protected override void HandleCustomCommand(string input, Player player)
        {
            if(player.Inventory.Contains("key")) IsCompleted = true;

            _currentFocus.HandleCommand(input, player, this);
        }
        public void ChangeFocus(IFocusState<IntroScene> newFocus)
        {
            _currentFocus = newFocus;
  
        }

    }
}
