using Haul.Engine.API;

namespace Haul.Contracts.Interfaces
{
    public interface IGameManager
    {
        Response StartGame();

        Response HandleRequest(Request request);
    }
}
