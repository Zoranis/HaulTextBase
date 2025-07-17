using Haul.Engine.API;
using Haul.Engine.Interfaces;
using HaulTextBase.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Engine.Services
{
    public class GameManager : IGameManager
    {
        
        public GameState? _gameState;

        public Response StartGame()
        {
            _gameState = new GameState();
            return new Response(_gameState);
        }

        public Response HandleRequest(Request request)
        {
            //Change gamestate based on request
            Response response = new(_gameState!);
            return response;
        }

        


    }
}
