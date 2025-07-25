using Haul.Contracts.Models;
using Haul.Engine.Game;

namespace HaulTextBase.Game
{
    public class GameState
    {
        public Player player;
        public Place currentPlace;


        public GameState()
        {
            player = new Player();
            currentPlace = new Place(); // Implement when persistence layer is ready
        }
    }
}
