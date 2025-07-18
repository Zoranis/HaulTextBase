﻿using System;
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
            Console.WriteLine("Initializing Basic UI...");
            _Controller = Controller;
            Response firstResponse = Controller.StartGame();
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
            HandleGameState(response.gameState);
            HandleDescription(response);
        }

        private void HandleGameState(GameState? gameState)
        {
            Console.WriteLine("Handling GameState...");
        }

        private void HandleDescription(Response response)
        {
            Console.WriteLine(response.description.Text["Place"]);
            Console.WriteLine(response.description.Text["Debug"]);
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
