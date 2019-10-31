using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleSearch.Controllers;
using VehicleSearch.Models;

namespace VehicleSearch.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAllMakes()
        {
            var vehicleController = new VehicleController();
            IEnumerable<string> makeResult = vehicleController.Get();

            Assert.IsTrue(makeResult.Count() == 2);

        }

        [TestMethod]
        public void GetFordModels()
        {
            var vehicleController = new VehicleController();
            IEnumerable<string> modelResult = vehicleController.Get("Ford");
            IEnumerable<string> emptyModelResult = vehicleController.Get("Toyota");

            Assert.IsTrue(modelResult.Count() == 2);
            Assert.IsTrue(emptyModelResult.Count() == 0);
        }

        [TestMethod]
        public void GetFordMustangModels()
        {
            var vehicleController = new VehicleController();
            IEnumerable<Vehicle> modelResult = vehicleController.Get("Ford", "Mustang");
            IEnumerable<Vehicle> emptyModelResult = vehicleController.Get("Ford", "Pinto");
            IEnumerable<Vehicle> blankModelResult = vehicleController.Get("", "");


            Assert.IsTrue(modelResult.Count() == 1);
            Assert.IsTrue(emptyModelResult.Count() == 0);
            Assert.IsTrue(blankModelResult.Count() == 0);
        }

        [TestMethod]
        public void GetFordF150Models()
        {
            var vehicleController = new VehicleController();
            IEnumerable<Vehicle> modelResult = vehicleController.Get("Ford", "F150");
            var model = modelResult.First();
            Assert.IsTrue(modelResult.Count() == 1);
            Assert.IsTrue(model is Truck);
            Assert.IsTrue(((Truck)model).BedLength == 6.5);

        }

    }
}
