using CarDealer.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private ICityService service;

        public CitiesController(ICityService cityService)
        {
            service = cityService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetAllCities();
            return Ok(result);
        }

    }
}
