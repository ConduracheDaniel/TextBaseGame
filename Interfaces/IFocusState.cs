using System.Collections;
using System.Collections.Generic;
using TextBaseGame.Players;
using TextBaseGame.Story.Scene;

namespace TextBaseGame.Interfaces
{
    public interface IFocusState
    {
        string Name { get; }
        string Description { get; }
        IEnumerable<string> AvailableCommands { get; }

        void HandleCommand(string input, Player player, IntroScene scene);

    }
}
