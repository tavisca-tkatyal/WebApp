using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        // GET api/vehicles/string
        [HttpGet("{number}")]
        public VehicleContracts Get(string number)
        {
            Service service = new Service();
            return service.ReturnVehicleData(number);
        }
    }
}
