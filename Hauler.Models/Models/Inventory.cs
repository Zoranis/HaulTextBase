using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Contracts.Models
{
    public class Inventory
    {
        private Dictionary<string, InventoryEntry> InventoryDictionary { get; set; } = new Dictionary<string, InventoryEntry>();

        public void AppendInventoryEntry(InventoryEntry appendingEntry)
        {
            if (InventoryDictionary.TryGetValue(appendingEntry.Commodity.Name, out var targetInventoryEntry))
            {
                targetInventoryEntry.Quantity += appendingEntry.Quantity;
            }
            else
            {
                InventoryDictionary[appendingEntry.Commodity.Name] = appendingEntry;
            }
        }


    }
}
