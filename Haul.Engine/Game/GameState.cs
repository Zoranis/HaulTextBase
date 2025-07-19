using Haul.Engine.Game;
using Haul.Engine.Places;
using HaulTextBase.Models;

namespace HaulTextBase.Game
{
    public class GameState
    {
        public Player player;
        public Place currentPlace;
        public int counter = 0;


        public GameState()
        {
            currentPlace = new SpacePort();
            player = new Player();
        }
    }
}
