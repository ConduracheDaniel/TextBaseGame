using TextBaseGame.Interfaces;
using TextBaseGame.Engine;
using System;

namespace BasedGameText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cum te numesti?");
            Console.WriteLine("Introdu numele eroului: ");
            string name = Console.ReadLine();
            IGame game = new GameEngine(name);
            game.Start();
        }
    }
}
