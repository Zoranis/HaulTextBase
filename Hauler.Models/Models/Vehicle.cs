namespace Haul.Contracts.Models
{
    public class Vehicle
    {
        public string Name { get; set; }
        public float HullCondition { get; set; } = 100.0f;
        public float MaxHullCondition { get; set; } = 100.0f;
        public int Fuel { get; set; } = 100;
        public int MaxFuel { get; set; } = 100;
        public int CargoCapacity { get; set; } = 10;

        public List<CargoLoad> Cargo { get; set; } = new List<CargoLoad>();


        public int GetAvailableCargoSpace()
        {
            return CargoCapacity - GetCurrentCargoLoad();
        }

        public int GetCurrentCargoLoad()
        {
            int load = 0;

            foreach (var item in Cargo)
            {
                load += item.Quantity;
            }

            return load;
        }
    }
}
