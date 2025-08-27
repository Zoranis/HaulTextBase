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
        public bool IsEngaged { get; set; } = false;

        public Dictionary<string, Inventory> StoreInventory { get; set; } = new();

        public List<string> AcceptedCommodities { get; set; } = new();
        
        public bool IsBuyingCommodity(string commodityName)
        {
            return AcceptedCommodities.Contains(commodityName);
        }

        public bool RemoveInventory(Inventory removeInventory)
        {
            if (!Has(removeInventory))
                return false;

            StoreInventory[removeInventory.Commodity.Name].Quantity -= removeInventory.Quantity;
            return true;
        }

        public bool Has(Inventory checkInventory)
        {
            if (StoreInventory.TryGetValue(checkInventory.Commodity.Name, out var inv))
            {
                return inv.Quantity >= checkInventory.Quantity;
            }
            return false;
        }

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
