using Haul.Contracts.Interfaces;
using Haul.Engine.API;
using Haul.Persistence;
using HaulTextBase.Game;

namespace Haul.Engine.Game
{
    public class GameManager(IPersistenceService persistenceService) : IGameManager
    {
        private readonly IPersistenceService _persistenceService = persistenceService;
        public GameState? CurrentGameState { get; set; }


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

        public void SaveGame()
        {
            if (CurrentGameState == null) {
                throw new InvalidOperationException("Game state is not initialized. Cannot save.");
            }

            _persistenceService.SaveGame(CurrentGameState);
        }

        public void LoadGame()
        {
           CurrentGameState = _persistenceService.LoadGame();
        }
    }
}
