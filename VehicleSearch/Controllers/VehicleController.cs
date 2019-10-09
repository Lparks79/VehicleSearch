using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VehicleSearch.enums;
using VehicleSearch.Models;

namespace VehicleSearch.Controllers
{
    public class VehicleController : ApiController
    {
        // GET: api/Vehicle
        public IEnumerable<string> Get()
        {
            return GetVehicles().Select(x => x.Make).Distinct().OrderBy(x => x);
        }

        // GET: api/Vehicle/Ford
        public IEnumerable<string> Get(string make)
        {
            return GetVehicles().Where(x => x.Make == make)?.Select(x => x.Model)?.OrderBy(x => x);
        }

        public IEnumerable<Vehicle> Get(string make, string model)
        {
            return GetVehicles().Where(x => x.Make == make && x.Model == model)?.OrderBy(x => x.Model);
        }

        public Vehicle Get(int id)
        {
            return GetVehicles().FirstOrDefault(x => x.Id == id);
        }

        // POST: api/Vehicle
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Vehicle/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Vehicle/5
        public void Delete(int id)
        {
        }

        private List<Vehicle> GetVehicles()
        {
            //Temporary data, to add database access later
            return new List<Vehicle>() { new Vehicle { Id = 1, Make = "Ford", Model = "Mustang", Year = 1965, Condition = VehicleCondition.Used, Price = 65999.99m },
                new Vehicle { Id = 2, Make = "Ford", Model = "F150", Year = 2020, Condition = VehicleCondition.New, Price = 53230.99m }, 
                new Vehicle { Id = 3, Make = "Cheverolet", Model = "Camaro", Year = 2016, Condition = VehicleCondition.New, Price = 32999.99m }
            };
        }
    }
}
