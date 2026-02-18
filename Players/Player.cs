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
    }
}
