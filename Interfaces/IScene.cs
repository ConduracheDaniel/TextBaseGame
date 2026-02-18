using TextBaseGame.Players;
namespace TextBaseGame.Interfaces
{

    // Interfață pentru o scenă
    public interface IScene
    {
        string Name { get; }
        string Description { get; }
        bool IsCompleted { get; }

        void Display();
        void ProcessCommand(string input, Player player);
    }



}
