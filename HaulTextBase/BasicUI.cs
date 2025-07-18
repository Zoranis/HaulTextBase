using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using Haul.Engine.API;
using Haul.Engine.Interfaces;
using HaulTextBase.Game;

namespace HaulTextBase
{
    public class BasicUI
    {
        private readonly IController _Controller;
        bool running = true;
        Response? currentResponse;

        public BasicUI(IController Controller)
        {
            _Controller = Controller;
            Console.WriteLine("Initializing Basic UI...");
            Response firstResponse = Controller.NewGame();
            currentResponse = firstResponse;
            loop();
        }

        private void loop()
        {
            while (running)
            {
                if (currentResponse == null)
                {
                    Console.WriteLine("No response received. Exiting loop.");
                    break;
                }
                HandleResponse(currentResponse);

                Request request = new Request(ReceiveUserInput());
                currentResponse = _Controller.HandleRequest(request);
            }

        }

        private void HandleResponse(Response response)
        {
            HandleGameState(response.GameState);
            HandleDescription(response);

        }

        private void HandleGameState(GameState? gameState)
        {
            throw new NotImplementedException();
        }

        private void HandleDescription(Response response)
        {
            Console.WriteLine(response.description);
        }

        private int ReceiveUserInput()
        {
            int choice = 0;
            Console.WriteLine("Enter your choice:");

            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
            char keyChar = keyInfo.KeyChar;

            if (char.IsDigit(keyChar))
            {
                choice = int.Parse(keyChar.ToString());
                Console.WriteLine($"\nYou pressed: {choice}");
            }
            else
            {
                Console.WriteLine("\nThat's not a digit.");
            }

            return choice;
        }
    }
}
