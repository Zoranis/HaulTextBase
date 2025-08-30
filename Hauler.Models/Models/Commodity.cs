using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Contracts.Models
{
    public class Commodity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal BasePrice { get; set; }

        public InventoryEntry CreateInventoryEntry(int quantity)
        {
            return new InventoryEntry
            {
                Commodity = this,
                Quantity = quantity
            };
        }

        public static Commodity ScrapMetal => new Commodity
        {
            Name = "ScrapMetal",
            Description = "Assorted pieces of scrap metal. Might be useful for crafting or selling.",
            BasePrice = 5
        };
        public static Commodity OldElectronics => new Commodity
        {
            Name = "OldElectronics",
            Description = "Outdated electronic devices. Could be sold to the right buyer.",
            BasePrice = 15
        };
        public static Commodity UsedClothing => new Commodity
        {
            Name = "UsedClothing",
            Description = "Worn-out clothing items. Some might find them useful.",
            BasePrice = 8
        };
    }
}
