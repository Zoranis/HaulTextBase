using Haul.Contracts.Models;
using Haul.Engine.API;
using Haul.Engine.Game;
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
            BuildStoreChoices(gameState);
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
            foreach (var currentStore in gameState.CurrentLocation.Stores)
            {
                if (!currentStore.Value.IsEngaged)
                    continue;

                foreach (var item in currentStore.Value.StoreInventory)
                {
                    gameState.Choices.Add(ChoiceIndex++, new Choice()
                    {
                        Action = () =>
                        {
                        },
                        Description = $"Buy {item.Key} - {item.Value.Quantity} available"
                    });
                }

            }
        }
    }

}
