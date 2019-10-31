using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VehicleSearch.enums;

namespace VehicleSearch.Models
{
    public class Vehicle
    {
        private List<Motor> _motors;

        public Vehicle ()
        {
            _motors = new List<Motor>();
        }
        public int Id { get; set; }
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Doors { get; set; }
        public int Mileage { get; set; }
        public VehicleCondition Condition { get; set; }
        public Decimal Price { get; set; }
        public List<Uri> ImageUrl { get; set; }
        public int MaxTowRating { get; set; }
        public int RangeInMiles { get; set; }
        public int SeatingCapacity { get; set; }

        public void Motors(Motor motor)
        {
            _motors.Add(motor);
        }
        public void Motors(List<Motor> motors)
        {
            _motors.AddRange(motors);
        }
        public List<Motor> Motors()
        {
            return _motors;
        }
    }
}

