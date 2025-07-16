using HaulTextBase.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Engine.API
{
    public static class Controller
    {
        public static Response NewGame()
        {
            return GameManager.Instance().NewGame();
        }
        public static Response HandleRequest(Request request)
        {
            return GameManager.Instance().HandleRequest(request);
        }
    }
}
