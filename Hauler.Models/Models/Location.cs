using Haul.Contracts.Interfaces;
using Haul.Contracts.Models;

namespace Haul.Contracts.Models
{
    public class Location
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Dictionary<string, Interactable> Interactables { get; set; } = new Dictionary<string, Interactable>();
        public Dictionary<string, Item> Items { get; set; } = new Dictionary<string, Item>();
        public Dictionary<string, Exit> Exits { get; set; } = new Dictionary<string, Exit>();
    }
}
