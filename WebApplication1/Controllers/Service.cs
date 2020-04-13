using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class Service
    {
        public VehicleContracts ReturnVehicleData(string carKey)
        {
            VehicleContracts vehicleContracts = new VehicleContracts();
            Dictionary<string, VehicleContracts> car1 = new Dictionary<string, VehicleContracts>();
            car1.Add("hr05an3810", new VehicleContracts()
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
            });
            car1.Add("hr05an3811", new VehicleContracts()
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
            });
            if (car1.TryGetValue(carKey, out VehicleContracts vehicle))
            {
                vehicleContracts = vehicle;
            }
            return vehicleContracts;

        }
    }
}
