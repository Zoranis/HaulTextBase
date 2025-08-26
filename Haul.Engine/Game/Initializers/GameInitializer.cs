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
                player = new Player()
                {
                    Vehicle = new Vehicle()
                    {
                        CargoCapacity = 100,
                        MaxFuel = 100,
                        Fuel = 100,
                        HullHealth = 100,
                        Name = "Rustbucket",
                    },
                },
                
            };

            InitializeExternals();
            _gameState.CurrentLocation = _gameState.Locations["StarportTerminal"];
            return _gameState;
        }

        private void InitializeExternals()
        {
            LocationsInitializer.AddLocations(_gameState!);
            ExitsInitializer.AddExits(_gameState!);
        }
    }
}