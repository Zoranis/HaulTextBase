using Haul.Contracts.Interfaces;

namespace Haul.Engine.API
{
    public class Controller(IGameManager gameManager) : IController
    {
        private IGameManager _gameManager { get; } = gameManager;
        public Response StartGame()
        {
            return _gameManager.HandleRequest();
        }
        public Response HandleRequest(Request request)
        {
            return _gameManager.HandleRequest(request);
        }
    }
}
