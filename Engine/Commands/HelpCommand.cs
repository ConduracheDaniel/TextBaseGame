using System;
using TextBaseGame.Interfaces;
using TextBaseGame.Players;

namespace TextBaseGame.Engine.Commands
{
    public class HelpCommand : ICommand
    {
        public string Name => "help";
        public string Description => "Afișează lista comenzilor disponibile.";

        public void Execute(Player player, IScene scene)
        {
            Console.WriteLine("Comenzi disponibile in contextul actual:");
            Console.WriteLine(scene.GetContextualHelp());
        }
    }
}
