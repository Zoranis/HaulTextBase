using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaulTextBase.Interfaces
{
    internal class ILocation
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<IInteractable> Interactables { get; set; } = new List<IInteractable>();
        
    }
}
