using Haul.Contracts.Models;
using Haul.Engine.Game;

namespace HaulTextBase.Game
{
    public class GameState
    {
        public Player player;
        public Location CurrentLocation = new();
        public Dictionary<string, Location> Locations;
        public static Location currentPlace;
        public Dictionary<int, Choice> Choices = new();
       
    }
}
