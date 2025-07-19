using Haul.Engine.API;
using Haul.Engine.Game;
using Haul.Engine.Interfaces;
using HaulTextBase.Game;

namespace Haul.Engine.Game
{
    public class GameManager : IGameManager
    {
        public GameState CurrentGameState;

        public GameManager()
        {
            CurrentGameState = new();
        }

        public Response HandleRequest(Request? request = null)
        {
            if (request == null)
                request = new Request(0);

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
            if (request.choice == 0)
                return;
        }


    }
}
