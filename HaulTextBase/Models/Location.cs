using HaulTextBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaulTextBase.Models
{
    internal class Location
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public List<IInteractable> Interactables { get; set; } = new List<IInteractable>();
    }
}
