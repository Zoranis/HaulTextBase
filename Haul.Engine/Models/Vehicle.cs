using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaulTextBase.Models
{
    internal class Vehicle
    {
        public string Name { get; set; }
        public float HullCondition { get; set; } = 100.0f;
        public float MaxHullCondition { get; set; } = 100.0f;
        public float Fuel { get; set; } = 100.0f;
        public float MaxFuel { get; set; } = 100.0f;
        public int CargoCapacity { get; set; } = 1000;
    }
}
