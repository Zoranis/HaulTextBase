using Haul.Contracts.Interfaces;
using Haul.Engine.API;
using Haul.Persistence;
using HaulTextBase.Game;

namespace Haul.Engine.Game
{
    public class GameManager : IGameManager
    {
        

        public GameState CurrentGameState;

        public GameManager()
        {
            CurrentGameState = new();
            var ps = new PersistenceService();
            ps.init();
        }

        public Response HandleRequest(Request? request = null)
        {
            if (request == null)
                request = new Request();

            BuildGameState(request);
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
