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
        private readonly IController _controller;
        private bool running = true;
        private Response? _currentResponse;
        private List<string> _output = new();
        private int lastChoice = 0;

        public BasicUI(IController Controller)
        {
            Console.WriteLine("Initializing Basic UI...");
            _controller = Controller;
            Response firstResponse = Controller.StartGame();
            _currentResponse = firstResponse;
            loop();
        }

        private void loop()
        {
            while (running)
            {
                if (_currentResponse == null)
                {
                    Console.WriteLine("No response received. Exiting loop.");
                    break;
                }

                _output.Clear();
                HandleResponse(_currentResponse);
                PrintOutput();
                Request request = new Request(ReceiveUserInput());
                _currentResponse = _controller.HandleRequest(request);
            }

        }

        private void PrintOutput()
        {
            Console.Clear();
            foreach (var line in _output)
            {
                Console.WriteLine(line);
            }
        }

        private void HandleResponse(Response response)
        {
            HandleGameState(response.gameState);
            HandleDescription(response);
        }

        private void HandleGameState(GameState? gameState)
        {
        }

        private void HandleDescription(Response response)
        {
            _output.Add(response.description.Text["Place"]);
            _output.Add($"Last choice: {lastChoice}");
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
            lastChoice = choice;
            return choice;
        }
    }
}
