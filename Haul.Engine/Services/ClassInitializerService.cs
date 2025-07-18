using Haul.Engine.Interfaces;
using HaulTextBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Engine.Services
{
    public class ClassInitializerService : IInitializer
    {
        public Place InitializePlace()
        {
            return new Places.SpacePort();

        }
    }
}
