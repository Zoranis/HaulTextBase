using HaulTextBase.Game;
using LiteDB;
using System.Diagnostics;

namespace Haul.Persistence
{
    public class PersistenceService : IPersistenceService
    {
        private LiteDatabase _liteDatabase;

        public PersistenceService()
        {
            
            // create a string that refers to the folder where the app is installed
            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            path += "\\Haul.db";
            File.Delete(path); // Delete the file if it exists to start fresh
            //write path to output console
            Debug.WriteLine($"Database path: {path}");
            using (_liteDatabase = new LiteDatabase(path))
            {
                // Initialize the database and create collections if they do not exist
            }
        }
        public void SaveGame(GameState gameState)
        {
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
