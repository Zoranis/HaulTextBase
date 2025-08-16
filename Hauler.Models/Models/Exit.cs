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
        public Exit(Location destination, string description, string name, bool isLocked = false)
        {
            Destination = destination;
            Description = description;
            Name = name;
            IsLocked = isLocked;
        }
    }
}
