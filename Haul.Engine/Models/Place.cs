using Haul.Engine.Interfaces;

namespace HaulTextBase.Models
{
    internal class Place
    {
        public required string Name { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public List<IInteractable> Interactables { get; set; } = new List<IInteractable>();
    }
}
