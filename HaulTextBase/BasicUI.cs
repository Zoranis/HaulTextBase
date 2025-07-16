using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Haul.Engine.API;

namespace HaulTextBase
{
    public class BasicUI
    {
        bool running = true;
        Response currentResponse;
        public BasicUI()
        {
            Console.WriteLine("Initializing Basic UI...");
            Response firstResponse = Controller.NewGame();
            currentResponse = firstResponse;
            loop();
            
        }

        private void loop()
        {
            while (running)
            {
                HandleResponse(currentResponse);
                Request request = new Request(ReceiveUserInput());
                currentResponse = Controller.HandleRequest(request);
            }

        }

        private void HandleResponse(Response response)
        {
            ShowMessage(response);
            
        }

        private void ShowMessage(Response response)
        {
            Console.WriteLine(response.GameState?.description);
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
