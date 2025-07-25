
using Haul.Engine.Game;
using HaulTextBase.Game;

namespace Haul.Engine.API
{
    public class Response
    {
        public GameState? gameState { get; set; }
        public Description description { get; set; }
        public Response(GameState newGameState, Description description)
        {
            this.gameState = newGameState;
            this.description = description;
        }

    }
}
