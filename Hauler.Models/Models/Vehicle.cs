namespace Haul.Contracts.Models
{
    public class Vehicle
    {
        public string Name { get; set; }
        public float HullCondition { get; set; } = 100.0f;
        public float MaxHullCondition { get; set; } = 100.0f;
        public float Fuel { get; set; } = 100.0f;
        public float MaxFuel { get; set; } = 100.0f;
        public int CargoCapacity { get; set; } = 1000;
    }
}
