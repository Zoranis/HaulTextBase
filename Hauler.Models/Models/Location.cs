using Haul.Contracts.Interfaces;
using Hauler.Contracts.Models;

namespace Haul.Contracts.Models
{
    public class Location
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Interactable> Interactables { get; set; } = new List<Interactable>();
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
