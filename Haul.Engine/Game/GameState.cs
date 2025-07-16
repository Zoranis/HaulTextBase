using Haul.Engine.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaulTextBase.Game
{
    public class GameState
    {
        public Player player;
        public string description;

        public GameState()
        {
            player = new Player();
            description = "Welcome to the game! Lets haul!";
        }

    }
}
