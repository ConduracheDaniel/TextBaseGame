using TextBaseGame.Players;
namespace TextBaseGame.Interfaces
{
    // Interfață pentru comenzi
    public interface ICommand
    {
        string Name { get; }
        string Description { get; }
        void Execute(Player player, IScene scene);
    }

}
