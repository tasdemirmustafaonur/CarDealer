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
    public class GearsController : ControllerBase
    {
        private IGearService service;

        public GearsController(IGearService gearService)
        {
            service = gearService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetAllGears();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var gearListResponse = service.GetGearById(id);
            if (gearListResponse != null)
            {
                return Ok(gearListResponse);
            }

            return NotFound();
        }
    }
}
