using Haul.Contracts.Models;
using Haul.Engine.Places.Spaceport;
using HaulTextBase.Game;
using System.Runtime.CompilerServices;

namespace Haul.Engine.Game.Initializers
{
    internal class GameInitializer
    {
        private Dictionary<string, Location> _locationsDictionary = new();
        private GameState? _gameState;
        public GameState InitializeGamestate()
        {
            _gameState = new GameState
            {
                player = new Player(),
                //currentPlace = _locationsDictionary["StarportTerminal"]
            };

            InitializeLocations();
            _gameState.CurrentLocation = _gameState.Locations["StarportTerminal"];
            return _gameState;
        }

        private void InitializeLocations()
        {
            LocationsInitializer.AddLocations(_gameState!);
            ExitsInitializer.AddExits(_gameState!);



            //// Phase 2: Add exits with proper references
            //_locationsDictionary["StarportTerminal"].Exits.Add(new Exit()
            //{
            //    Name = "StarportStorage",
            //    Description = "The exit to the spaceport leads out into the bustling streets of the city.",
            //    Destination = _locationsDictionary["StarportStorage"]
            //});

            //_locationsDictionary["StarportStorage"].Exits.Add(new Exit()
            //{
            //    Name = "StarportTerminal",
            //    Description = "A rusty metal door leading back to the terminal hall, that somehow sounds as silent as this storage room.",
            //    Destination = _locationsDictionary["StarportTerminal"]
            //});
        }

        //public Location GetLocation(string locationKey)
        //{
        //    if (_locationsDictionary.TryGetValue(locationKey, out var location))
        //    {
        //        return location;
        //    }
        //    throw new KeyNotFoundException($"Location '{locationKey}' not found.");
        //}
    }
}