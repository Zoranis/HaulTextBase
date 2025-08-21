
using Haul.Contracts.Models;
using Haul.Engine.Game;
using HaulTextBase.Game;

namespace Haul.Engine.API
{
    public class Response
    {
        public GameState gameState { get; set; }
        private int ChoiceIndex = 0;

        public Response(GameState newGameState)
        {
            this.gameState = newGameState;

            if (gameState == null)
            {
                throw new InvalidOperationException("Game state is not initialized. Start or load a game.");
            }

            if (gameState.CurrentLocation.Exits != null)
            {
                foreach (Exit exit in gameState.CurrentLocation.Exits)
                {
                    gameState.Choices.Add(ChoiceIndex++, new Choice()
                    {
                        Action = () =>
                        {
                            gameState.CurrentLocation = gameState.Locations[exit.Destination];
                        },
                        Description = "Go to " + exit.Name
                    });
                }
            }

        }

    }
}
