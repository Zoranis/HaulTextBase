using Haul.Engine.API;

namespace Haul.Engine.Interfaces
{
    public interface IController
    {
        Response HandleRequest(Request request);
        Response NewGame();
    }
}