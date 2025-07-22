using Haul.Engine.Game;
using Haul.Engine.Places.Spaceport;
using HaulTextBase.Models;

namespace HaulTextBase.Game
{
    public class GameState
    {
        public Player player;
        public Place currentPlace;


        public GameState()
        {
            currentPlace = new SpacePort();
            player = new Player();
        }
    }
}
