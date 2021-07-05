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
    public class TownsController : ControllerBase
    {
        private ITownService service;

        public TownsController(ITownService townService)
        {
            service = townService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetAllTowns();
            return Ok(result);
        }
    }
}
