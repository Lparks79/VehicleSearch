using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleSearch.Models
{
    public class RV : Vehicle
    {
        public int Hours { get; set; }
        public bool HasGenerator { get; set; }
        public bool HasSlideout { get; set; }
        public int GeneratorHours { get; set; }
        public int NumberOfBeds { get; set; }
        public decimal SquareFeet { get; set; }
    }
}