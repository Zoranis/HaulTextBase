using Haul.Engine.API;

namespace Haul.Contracts.Interfaces
{
    public interface IController
    {
        Response HandleRequest(Request request);
        Response StartGame();
    }
}