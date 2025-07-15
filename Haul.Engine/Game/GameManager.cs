using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaulTextBase.Game
{
    internal class GameManager
    {
        public GameState? _gameState;

        public void NewGame()
        {
            _gameState = new GameState();
            _gameState._player = new Player();
        }

    }
}
