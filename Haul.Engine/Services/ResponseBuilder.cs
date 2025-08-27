using Haul.Contracts.Models;
using Haul.Engine.API;
using HaulTextBase.Game;

namespace Haul.Engine.Services
{
    public class ResponseBuilder
    {
        private static int ChoiceIndex = 0;


        public static void BuildResponse(GameState gameState)
        {
            ChoiceIndex = 0;
            BuildExitChoices(gameState);
        }



        private static void BuildExitChoices(GameState gameState)
        {
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

        private static void BuildStoreChoices(GameState gameState)
        {
            foreach (var store in gameState.CurrentLocation.Stores)
            {
                foreach (var item in store.Value.StoreInventory)
                {
                    gameState.Choices.Add(ChoiceIndex++, new Choice()
                    {
                        Action = () =>
                        {
                            // Implement store interaction logic here
                        },
                        Description = $"Buy {item.Key} - {item.Value.Quantity} available"
                    });
                }

            }
        }
    }

}
