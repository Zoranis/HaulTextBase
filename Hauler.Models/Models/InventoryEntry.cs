using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Contracts.Models
{
    public class InventoryEntry
    {
        public Commodity Commodity { get; set; }
        public int Quantity { get; set; }

    }
}
