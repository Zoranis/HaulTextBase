using Haul.Engine.Interfaces;
using Haul.Engine.Models;
using Haul.Engine.Services;
using System.Runtime.ExceptionServices;

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
