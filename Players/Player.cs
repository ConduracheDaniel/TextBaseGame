using System.Collections.Generic;

namespace TextBaseGame.Players
{
    // Reprezintă jucătorul
    public class Player
    {
        public string Name { get; set; }
        public List<string> Inventory { get; private set; }

        public Player(string name)
        {
            Name = name;
            Inventory = new List<string>();
        }

        public void AddItem(string item)
        {
            if (!Inventory.Contains(item))
                Inventory.Add(item);
        }
        public void RemoveItem(string item)
        {
            if (Inventory.Contains(item))
                Inventory.Remove(item);
        }
        public void DisplayInventory()
        {
            if (Inventory.Count == 0)
            {
                System.Console.WriteLine("Inventar gol.");
            }
            else
            {
                System.Console.WriteLine("Inventar:");
                foreach (var item in Inventory)
                {
                    System.Console.WriteLine("- " + item);
                }
            }
        }
    }
}
