using Haul.Contracts.Interfaces;
using Haul.Contracts.Models;

namespace Haul.Contracts.Models
{
    public class Location
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Dictionary<string, Interactable>? Interactables { get; set; } = new Dictionary<string, Interactable>();
        public List<string>? ItemKeys { get; set; }
        public List<Exit> Exits { get; set; } = new List<Exit>();

        public Location()
        {
            Title = "Void of Error";
            Description = "An undefined location. It's a glimpse of insanity.";
        }

    }
}
