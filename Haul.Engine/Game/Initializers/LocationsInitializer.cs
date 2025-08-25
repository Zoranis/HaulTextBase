using Haul.Contracts.Models;
using HaulTextBase.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Engine.Game.Initializers
{
    public class LocationsInitializer
    {
        public static void AddLocations(GameState gameState)
        {
            gameState.Locations = new Dictionary<string, Location>
            {
                {
                    "StarportTerminal",
                    new Location()
                    {
                        Title = "Starport Terminal",
                        Description = "The main hall of the starport stands mostly silent, save for a small knot of weary passengers slumped on cracked benches, guarding their meager luggage. Dust swirls through the sunbeams from broken skylights, settling on rusted fixtures. Outside the grimy windows, a lone battered freighter bakes in the desert heat, its crew lazily unloading in the shimmer of the landing pad.",
                        Interactables = {},
                        ItemKeys = {},
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
                    }
                }
            };
        }
    }
}
