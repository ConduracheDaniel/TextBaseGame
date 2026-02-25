using System.Collections;
using System.Collections.Generic;
using TextBaseGame.Players;
using TextBaseGame.Story;
using TextBaseGame.Story.Scene;

namespace TextBaseGame.Interfaces
{
    public interface IFocusState<TScene> where TScene : BaseScene
    {
        string Name { get; }
        string Description { get; }
        IEnumerable<string> AvailableCommands { get; }

        void HandleCommand(string input, Player player, TScene scene);

    }
}
