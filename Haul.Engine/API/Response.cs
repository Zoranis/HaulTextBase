using HaulTextBase.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Engine.API
{
    public class Response
    {
        public GameState? GameState { get; set; }
        public Response(GameState newGameState )
        {
            GameState = newGameState;
        }
    }
}
