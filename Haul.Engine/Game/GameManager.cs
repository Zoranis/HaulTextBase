using Haul.Contracts.Interfaces;
using Haul.Engine.API;
using Haul.Persistence;
using HaulTextBase.Game;

namespace Haul.Engine.Game
{
    public class GameManager : IGameManager
    {
        public GameState? CurrentGameState;

        public GameManager()
        {
            var ps = new PersistenceService();
        }

        public Response StartGame()
        {
            CurrentGameState = GameInitializer.InitializeGamestate();
            return new Response(CurrentGameState);
        }

        public Response HandleRequest(Request request)
        {
            if (CurrentGameState == null)
            {
                throw new InvalidOperationException("Game state is not initialized. Start or load a game.");
            }

            // Process the request and update the game state

            return new Response(CurrentGameState);
        }
    }
}
