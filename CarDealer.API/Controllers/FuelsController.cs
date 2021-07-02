using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Business.Interfaces;

namespace CarDealer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelsController : ControllerBase
    {
        private IFuelService fuelService;

        public FuelsController(IFuelService fuelService)
        {
            this.fuelService = fuelService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = fuelService.GetAllFuels();
            return Ok(result);
        }
    }
}
