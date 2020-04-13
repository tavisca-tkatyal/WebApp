using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class VehiclesController : Controller
    {
        Dictionary<string, VehiclesController> dict = null;


        //creating attributes
        public string brand { get; set; }
        public string model { get; set; }
        public string fuelCapacity { get; set; }
        public string engineSize { get; set; }
        public string cost { get; set; }
        public string mileage { get; set; }
        public string bodyType { get; set; }
        public string numberOfCylinders { get; set; }
        public string gear { get; set; }
        public string fuelType { get; set; }
        public VehiclesController Car1 { get; internal set; }
        public VehiclesController Car2 { get; internal set; }

        public VehiclesController()
        {
          FillVehicles();
        }
        public void FillVehicles()
        {

            dict = new Dictionary<string, VehiclesController>
            {
                { "hr05an3810", Car1 },
                { "hr05an3811", Car2 }
            };
        }
        
        // GET api/vehicles/string
        [HttpGet("{number}")]
        public ActionResult<VehiclesController> Get(string number)
        {

            //if (dict.ContainsKey(number))
            //{

            return dict[number];
            //}
            //else
            //{
               // return  dict[number];
            //}
        }


    }
}
