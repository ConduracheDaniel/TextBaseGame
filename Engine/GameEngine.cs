using BasedGameText;
using System;
using System.Collections.Generic;
using TextBaseGame.Interfaces;
using TextBaseGame.Players;
using TextBaseGame.Story;
using TextBaseGame.Story.Scene;

namespace TextBaseGame.Engine
{
    // Motorul principal al jocului
    public class GameEngine : IGame
    {
        private List<Chapter> chapters;
        private Player player;

        public GameEngine(string name)
        {
            player = new Player(name);

            chapters = new List<Chapter>
            {
                new Chapter("Capitolul 1 - Trezirea",
                    new List<IScene>
                    {
                        new IntroScene(),
                        new EscapeRoomScene()
                    }),

                new Chapter("Capitolul 2 - Explorarea",
                    new List<IScene>
                    {
                        new ForestScene(),
                        new BridgeScene()
                    }),

                new Chapter("Capitolul 3 - Finalul",
                    new List<IScene>
                    {
                        new CastleGateScene(),
                        new FinalScene()
                    })
            };
        }

        public void Start()
        {
            Console.WriteLine("=== Joc Text Based ===");
            Console.WriteLine($"Bine ai venit {player.Name}");

            foreach (var chapter in chapters)
            {
                Console.WriteLine($"\n--- {chapter.Title} ---");

                while (chapter.HasScenes)
                {
                    var scene = chapter.GetNextScene();
                    RunScene(scene);
                }
            }

            Console.WriteLine("\nFelicitări! Ai terminat jocul.");
        }

        private void RunScene(IScene scene)
        {
            while (!scene.IsCompleted)
            {
                scene.Display();
                Console.Write("\n> ");
                var input = Console.ReadLine();
                scene.ProcessCommand(input, player);
            }
        }
    }
}
