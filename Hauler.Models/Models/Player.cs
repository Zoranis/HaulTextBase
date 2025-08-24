using Haul.Contracts.Models;
using HaulTextBase.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Engine.Game
{
    public class Player
    {
        public int Credits { get; set; } = 0;

        public Vehicle? Vehicle { get; set; }

    }
}
