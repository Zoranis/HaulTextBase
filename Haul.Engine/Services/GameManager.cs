using Haul.Engine.API;
using Haul.Engine.Game;
using Haul.Engine.Interfaces;
using HaulTextBase.Game;

namespace Haul.Engine.Services
{
    public class GameManager : IGameManager
    {
        public Response HandleRequest(Request? request = null, GameState? gameState = null)
        {
            if (request == null)
                request = new Request(0);

            if (gameState == null)
            {
                gameState = new GameState();
            }

            BuildGameState(request, gameState);
            var description = BuildDescription(gameState);
            return new Response(gameState, description);
        }

        private Description BuildDescription(GameState gameState)
        {
            Description newDescription = new();
            newDescription.Text["Place"] = gameState.currentPlace.Description;
            return newDescription;
        }

        private void BuildGameState(Request request, GameState gameState)
        {
            if (request.choice == 0)
                return;
        }


    }
}
