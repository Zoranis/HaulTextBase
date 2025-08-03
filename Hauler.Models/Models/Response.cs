
using Haul.Engine.Game;
using HaulTextBase.Game;

namespace Haul.Engine.API
{
    public class Response
    {
        public GameState gameState { get; set; }
        public Response(GameState newGameState)
        {
            this.gameState = newGameState;
        }

    }
}
