using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Contracts.Interfaces
{
    internal interface ITradeable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Weight { get; }
    }
}
