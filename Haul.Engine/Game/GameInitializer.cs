using Haul.Contracts.Models;
using Haul.Engine.Places.Spaceport;
using HaulTextBase.Game;

namespace Haul.Engine.Game
{
    internal class GameInitializer
    {
        private Dictionary<string, Location> _locationsDictionary = new();
        public GameState InitializeGamestate()
        {
            // Create the main hall
            _locationsDictionary["StarportTerminal"] = new()
            {
                Title = "Starport Main Hall",
                Description = "The main hall of the starport stands mostly silent, save for a small knot of weary passengers slumped on cracked benches, guarding their meager luggage. Dust swirls through the sunbeams from broken skylights, settling on rusted fixtures. Outside the grimy windows, a lone battered freighter bakes in the desert heat, its crew lazily unloading in the shimmer of the landing pad."
                
                exitToStorage = new Exit(
                destination: _locations,
                description: "A rusty metal door leading to the storage area.",
                name: "Storage Room Door"
            )
            };

            // Create exits to connect the rooms
            var

            var exitToMainHall = new Exit(
                destination: mainHall,
                description: "A doorway leading back to the main hall.",
                name: "Main Hall Door"
            );

            // Add exits as interactables (since Location doesn't have an Exits property)
            // Note: This assumes Exit implements IInteractable or can be converted to Interactable
            // If this doesn't work, we may need to create Exit wrapper classes that inherit from Interactable

            // Create a player
            var player = new Player()
            {
                Credits = 1000
            };

            // Create and return the game state
            var gameState = new GameState()
            {
                player = player,
                currentPlace = mainHall  // Start the player in the main hall
            };

            return gameState;
        }
    }
}
