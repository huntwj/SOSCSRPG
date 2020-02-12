using Engine.Models;

namespace Engine.ViewModels
{
    class GameSession
    {
        Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player
            {
                Name = "Scott",
                Gold = 1_000_000
            };
        }
    }
}
