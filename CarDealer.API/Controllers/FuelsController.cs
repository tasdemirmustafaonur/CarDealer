using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.API.Filters;
using CarDealer.Business.Interfaces;
using CarDealer.Business.DataTransferObjects;

namespace CarDealer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelsController : ControllerBase
    {
        private IFuelService service;

        public FuelsController(IFuelService fuelService)
        {
            service = fuelService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetAllFuels();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var fuelListResponse = service.GetFuelById(id);
            if (fuelListResponse != null)
            {
                return Ok(fuelListResponse);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult AddFuels(AddNewFuelRequest request)
        {
            if (ModelState.IsValid)
            {
                int fuelId = service.AddFuel(request);
                return CreatedAtAction(nameof(GetById), routeValues: new {id = fuelId}, value: null);
            }

            return BadRequest(ModelState);
        }

        
    }
}
