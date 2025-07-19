using HaulTextBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Engine.Places
{
    internal class SpacePort : Place
    {
        public SpacePort()
        {
            Name = "Space Port";
            // a description of a spaceport that is on a remote planet, with very little traffic,
            // and obviously poor maintenance.
            Description = "You find yourself in a spaceport on a remote planet. The place is eerily quiet, with only a few ships docked. The walls are stained with age, and the lights flicker intermittently. It seems like this place hasn't seen much traffic in a long time, and the maintenance is clearly lacking. You can hear the distant hum of machinery, but it feels like you're the only one here.";

        }
        
        
    }
}
