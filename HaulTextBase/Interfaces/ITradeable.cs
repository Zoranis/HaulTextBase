using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaulTextBase.Interfaces
{
    internal class ITradeable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Weight { get; }
    }
}
