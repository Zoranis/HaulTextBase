using HaulTextBase.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Engine.Game
{
    internal static class GameInitializer
    {
        public static GameState InitializeGamestate()
        {
            // Initialize the game state
            GameState gameState = new GameState();
            
            return gameState;
        }
    }
}
