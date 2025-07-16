using Haul.Engine.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaulTextBase.Game
{
    public class GameManager
    {
        private static GameManager? _instance = null;
        
        public static GameManager Instance() 
        { 
            if (_instance == null)
            {
                _instance = new GameManager();
            }
            return _instance;
        } 

        public GameState? _gameState;

        public Response NewGame()
        {
            _gameState = new GameState();
            return new Response(_gameState);
        }

        public Response HandleRequest(Request request)
        {
            // Process the request and return a response
            // This is a placeholder implementation
            if (_gameState == null)
            {
                NewGame();
            }
            // Add logic to handle the request and populate the response
            Response response = new(_gameState!);
            // Populate response based on the game state and request
            return response;
        }

    }
}
