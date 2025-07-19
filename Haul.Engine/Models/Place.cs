using Haul.Engine.Interfaces;
using Haul.Engine.Models;

namespace HaulTextBase.Models
{
    public class Place
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<IInteractable> Interactables { get; set; } = new List<IInteractable>();
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
