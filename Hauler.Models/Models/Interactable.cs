using Haul.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haul.Contracts.Models
{
    public class Interactable : IInteractable
    {
        public bool IsActive { get; set; } = false;

        public void Disengage()
        {
            IsActive = false;
        }

        public void Engage()
        {
            IsActive = true;
        }
    }
}
