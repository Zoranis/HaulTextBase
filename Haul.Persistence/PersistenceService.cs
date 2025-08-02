using Haul.Contracts.Interfaces;
using Haul.Contracts.Models;
using Hauler.Contracts.Models;
using HaulTextBase.Game;
using LiteDB;
using System.Diagnostics;

namespace Haul.Persistence
{
    public class PersistenceService
    {
        private ILiteDatabase _liteDatabase;
        public void init()
        {
            // create a string that refers to the folder where the app is installed
            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            path += "\\Haul.db";
            //write path to output console
            Debug.WriteLine($"Database path: {path}");
            using (_liteDatabase = new LiteDatabase(path))
            {
                // Initialize the database and create collections if they do not exist
            }
        }

        public void SaveGame(GameState gameState)
        {
            // I'm treating gamestate as a collection, but there should be only one game state.
            // This might cause me to treat it as an allready implemented multy save capable system.
            // This will conflict with the fact that the rest of the collecitons represent a single game.
            // On the other hand, maybe the collections should be static and be relevant for multiple games saved in 
            // multiple documents in the gamestate collection.
            var games = _liteDatabase.GetCollection<GameState>("gamestate");
            games.Upsert(gameState);
        }

        public GameState LoadGame()
        {
            // Load the game state from the database
            var games = _liteDatabase.GetCollection<GameState>("gamestate");
            var gameState = games.FindOne(x => true); // Assuming there's only one game state
            if (gameState != null)
            {
                // Do something with the loaded game state, e.g., return it or set it in the game manager
                Debug.WriteLine("Game state loaded successfully.");
                return gameState;
            }
            else
            {
                throw new Exception("No game state found in the database.");
            }
        }
    }
}
