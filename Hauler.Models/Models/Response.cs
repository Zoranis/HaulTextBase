
using Haul.Contracts.Models;
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

            if (gameState == null)
            {
                throw new InvalidOperationException("Game state is not initialized. Start or load a game.");
            }


        }

    }
}
