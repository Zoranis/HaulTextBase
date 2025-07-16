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
            while(running)
            {
                
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
        private void ReceiveUserInput()
        {
            Console.WriteLine("Enter your choice:");

            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
            char keyChar = keyInfo.KeyChar;

            if (char.IsDigit(keyChar))
            {
                int number = int.Parse(keyChar.ToString());
                Console.WriteLine($"\nYou pressed: {number}");
            }
            else
            {
                Console.WriteLine("\nThat's not a digit.");
            }

            Request request = new Request(input);
            currentResponse = Controller.HandleRequest(request);
            HandleResponse(currentResponse);
        }
    }
}
