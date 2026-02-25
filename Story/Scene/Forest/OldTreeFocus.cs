using System.Collections.Generic;
using TextBaseGame.Interfaces;
using TextBaseGame.Players;

namespace TextBaseGame.Story.Scene
{
    internal class OldTreeFocus : IFocusState<ForestScene>
    {
        public string Name => throw new System.NotImplementedException();

        public string Description => throw new System.NotImplementedException();

        public IEnumerable<string> AvailableCommands => throw new System.NotImplementedException();

        public void HandleCommand(string input, Player player, ForestScene scene)
        {
            throw new System.NotImplementedException();
        }
    }
}