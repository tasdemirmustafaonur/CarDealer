using CarDealer.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.API.Filters;
using CarDealer.Business.DataTransferObjects;

namespace CarDealer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private IVehicleService service;
        public VehiclesController(IVehicleService vehicleService)
        {
            service = vehicleService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetAllVehicles();
            return Ok(result);
        }

        [HttpGet("{id}")]
        [VehicleExists]
        public IActionResult GetById(int id)
        {
            var vehicleListResponse = service.GetVehicleById(id);
            if (vehicleListResponse != null)
            {
                return Ok(vehicleListResponse);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult AddVehicle(AddNewVehicleRequest request)
        {
            if (ModelState.IsValid)
            {
                int vehicleId = service.AddVehicle(request);
                return CreatedAtAction(nameof(GetById), routeValues: new {id = vehicleId}, value: null);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        [VehicleExists]
        public IActionResult UpdateVehicle(int id, EditVehicleRequest request)
        {
            if (ModelState.IsValid)
            {
                int newItemId = service.UpdateVehicle(request);
                return Ok();
            }

            return BadRequest(ModelState);
        }

    }
}
