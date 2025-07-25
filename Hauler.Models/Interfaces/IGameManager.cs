using Haul.Engine.API;

namespace Haul.Contracts.Interfaces
{
    public interface IGameManager
    {
        Response HandleRequest(Request? request = null);
    }
}
