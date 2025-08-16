using Haul.Contracts.Interfaces;
using Haul.Contracts.Models;

namespace Haul.Contracts.Models
{
    public class Location
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Dictionary<string, Interactable> Interactables { get; set; } = new Dictionary<string, Interactable>();
        public List<string> ItemKeys { get; set; }
        public List<Exit> Exits { get; set; }
    }
}
