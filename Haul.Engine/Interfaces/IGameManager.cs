using Haul.Engine.API;

namespace Haul.Engine.Interfaces
{
    public interface IGameManager
    {
        Response StartGame();
        Response HandleRequest(Request request);
    }
}
