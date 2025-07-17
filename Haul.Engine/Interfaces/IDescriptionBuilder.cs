using HaulTextBase.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Engine.Interfaces
{
    internal interface IDescriptionBuilder
    {
        string BuildDescription(GameState gameState);
    }
}
