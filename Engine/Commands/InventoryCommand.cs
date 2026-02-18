using System;
using TextBaseGame.Interfaces;
using TextBaseGame.Players;

namespace TextBaseGame.Engine.Commands
{
    internal class InventoryCommand : ICommand
    {
        public string Name => "inventory";
        public string Description => "Afișează inventarul jucătorului.";

        public void Execute(Player player, IScene scene)
        {
            player.DisplayInventory();
        }
    }
}
