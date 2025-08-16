using Haul.Contracts.Models;
using Haul.Engine.Game;

namespace HaulTextBase.Game
{
    public class GameState
    {
        public Player player;
        public Dictionary<string, Location> Locations;
        public Location currentPlace;
       
    }
}
