using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VehicleSearch.enums;

namespace VehicleSearch.Models
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Doors { get; set; }
        public int Mileage { get; set; }
        public VehicleCondition Condition { get; set; }
        public Decimal Price { get; set; }
    }
}

