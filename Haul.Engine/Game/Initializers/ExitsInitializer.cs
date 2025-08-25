using Haul.Contracts.Models;
using HaulTextBase.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Engine.Game.Initializers
{
    public static class ExitsInitializer
    {
        public static void AddExits(GameState gameState)
        {
            var locations = gameState.Locations;
            locations["StarportTerminal"].Exits =
                new List<Exit>()
                    {
                        new Exit()
                        {
                            Name = "StarportStorage",
                            Description = "The exit to the spaceport leads out into the bustling streets of the city.",
                            Destination = "StarportStorage"
                        }
                    };
            locations["StarportStorage"].Exits =
                new List<Exit>()
                    {
                        new Exit()
                            {
                                Name = "StarportTerminal",
                                Description = "A rusty metal door leading back to the terminal hall, that somehow sounds as silent as this storage room.",
                                Destination = "StarportTerminal"
                            }
                    };
        }
    }
}
