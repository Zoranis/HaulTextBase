using Haul.Engine.API;
using HaulTextBase.Game;

namespace Haul.Engine.Interfaces
{
    public interface IGameManager
    {
        Response HandleRequest(Request? request = null, GameState? gameState = null);
    }
}
