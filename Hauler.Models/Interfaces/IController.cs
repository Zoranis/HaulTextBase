using Haul.Engine.API;

namespace Haul.Contracts.Interfaces
{
    public interface IController
    {
        Response PostRequest(Request request);
        Response StartGame();
    }
}