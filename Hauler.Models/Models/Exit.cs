using Haul.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Contracts.Models
{
    public class Exit
    {
        public Location Destination { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public bool IsLocked { get; set; }
       
    }
}
