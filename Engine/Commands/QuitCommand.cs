using System;
using TextBaseGame.Interfaces;
using TextBaseGame.Players;

namespace TextBaseGame.Engine.Commands
{


    public class QuitCommand : ICommand
    {
        public string Name => "quit";
        public string Description => "Închide jocul.";

        public void Execute(Player player, IScene scene)
        {
            Console.WriteLine("Joc închis.");
            Environment.Exit(0);
        }
    }
}
