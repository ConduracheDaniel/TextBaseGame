using System;
using System.Collections.Generic;
using TextBaseGame.Engine.Commands;
using TextBaseGame.Interfaces;
using TextBaseGame.Players;

namespace TextBaseGame.Story
{
    // Clasă abstractă pentru scene (reduce duplicarea codului)
    public abstract class BaseScene : IScene
    {
        protected Dictionary<string, ICommand> commands;
        public abstract string Name { get; }
        public abstract string Description { get;}
        public bool IsCompleted { get; protected set; }

        protected BaseScene()
        {
            commands = new Dictionary<string, ICommand>
            {
                { "help", new HelpCommand() },
                { "quit", new QuitCommand() }
            };
        }

        public virtual void Display()
        {
            Console.WriteLine($"\n[{Name}]");
            Console.WriteLine(Description);
        }

        public virtual void ProcessCommand(string input, Player player)
        {
            if (commands.ContainsKey(input))
            {
                commands[input].Execute(player, this);
            }
            else
            {
                HandleCustomCommand(input, player);
            }
        }

        protected abstract void HandleCustomCommand(string input, Player player);
    }

}
