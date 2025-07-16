using Haul.Engine.Interfaces;

namespace HaulTextBase.Models
{
    internal class Location
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public List<IInteractable> Interactables { get; set; } = new List<IInteractable>();
    }
}
