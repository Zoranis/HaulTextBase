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
            return HandleRequest();
        }

        public Response HandleRequest(Request? request = null)
        {
            var description = BuildDescription();
            return new Response(CurrentGameState, description);
        }

        private Description BuildDescription()
        {
            Description newDescription = new();
            newDescription.Text["Place"] = CurrentGameState.currentPlace.Description;
            return newDescription;
        }

        private void BuildGameState(Request request)
        {
            if (request.Choice == 0)
                return;
        }


    }
}
