using Haul.Contracts.Models;
using Haul.Engine.Places.Spaceport;
using HaulTextBase.Game;

namespace Haul.Engine.Game
{
    internal class GameInitializer
    {
        private Dictionary<string, Location> _locationsDictionary = new();
        private GameState? _gameState;
        public GameState InitializeGamestate()
        {
            InitializeLocations();

            _gameState = new GameState
            {
                player = new Player(),
                Locations = _locationsDictionary,
                currentPlace = _locationsDictionary["StarportTerminal"]
            };

            return _gameState;
        }

        private void InitializeLocations()
        {
            _locationsDictionary = new Dictionary<string, Location>
            {
                {
                    "StarportTerminal",
                    new Location()
                    {
                        Title = "Starport Terminal",
                        Description = "The main hall of the starport stands mostly silent, save for a small knot of weary passengers slumped on cracked benches, guarding their meager luggage. Dust swirls through the sunbeams from broken skylights, settling on rusted fixtures. Outside the grimy windows, a lone battered freighter bakes in the desert heat, its crew lazily unloading in the shimmer of the landing pad.",
                        Interactables = {},
                        ItemKeys = {},
                        Exits = new List<Exit>
                        {
                            {
                                new Exit()
                                {
                                    Name = "StarportStorage",
                                    Description = "The exit to the spaceport leads out into the bustling streets of the city.",
                                    Destination = _locationsDictionary["StarportStorage"]
                                }
                            }
                        }
                    }
                },
                {
                    "StarportStorage",
                    new Location()
                    {
                        Title = "Starport Storage Room",
                        Description = "A dim, cramped room with a flickering light, rusted lockers, and dust-covered crates. Damp stains streak the walls; the air smells of stale metal.",
                        Interactables = {},
                        ItemKeys = {},
                        Exits = new List<Exit>
                        {
                            {
                                new Exit()
                                {
                                    Name = "StarportTerminal",
                                    Description = "A rusty metal door leading back to the terminal hall, that somehow sounds as silent as this storage room.",
                                    Destination = _locationsDictionary["StarportTerminal"]
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}