using VehicleSearch.enums;

namespace VehicleSearch.Models
{
    public class Engine : Motor
    {
        public FuelType FuelType { get; set; }
        public int HorsePower { get; set; }
        public int Torque { get; set; }
        public int NumberCylinders { get; set; }
    }
}