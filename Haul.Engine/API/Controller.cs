using Haul.Engine.Interfaces;
using Haul.Engine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Engine.API
{
    public class Controller(IGameManager gameManager) : IController
    {
        private IGameManager _gameManager { get; } = gameManager;
        public Response NewGame()
        {
            return _gameManager.StartGame();
        }
        public Response HandleRequest(Request request)
        {
            return _gameManager.HandleRequest(request);
        }
    }
}
