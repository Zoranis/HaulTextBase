using Haul.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Contracts.Models
{
    public class Store : IInteractable
    {
        public bool IsEngaged { get; private set; }
        public Inventory StoreInventory { get; set; } = new();

        public void Disengage()
        {
            IsEngaged = false;
        }
        
        public void Engage()
        {
            IsEngaged = true;
        }


    }
}
