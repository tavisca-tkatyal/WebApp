using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class Service
    {
        public VehiclesController Car1 { get; set; } = new VehiclesController()
        {

            brand = "suzuki",
            model = "swift",
            fuelCapacity = "40l",
            engineSize = "1248cc",
            cost = "6lakh",
            mileage = "21.21kmpl",
            bodyType = "hatchback",
            numberOfCylinders = "4",
            gear = "manual",
            fuelType = "petrol"
        };

        public VehiclesController Car2 { get; set; } = new VehiclesController()
        {
            brand = "hyundai",
            model = "verna",
            fuelCapacity = "45l",
            engineSize = "1497cc",
            cost = "10lakh",
            mileage = "20.5kmpl",
            bodyType = "sedan",
            numberOfCylinders = "5",
            gear = "automatic",
            fuelType = "diesel"
        };
    }
}
