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
        [GearExists]
        public IActionResult GetById(int id)
        {
            var gearListResponse = service.GetGearById(id);
            if (gearListResponse != null)
            {
                return Ok(gearListResponse);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult AddGears(AddNewGearRequest request)
        {
            if (ModelState.IsValid)
            {
                int gearId = service.AddGear(request);
                return CreatedAtAction(nameof(GetById), routeValues: new {id = gearId}, value: null);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        [GearExists]
        public IActionResult UpdateGear(int id, EditGearRequest request)
        {
            if (ModelState.IsValid)
            {
                int newItemId = service.UpdateGear(request);
                return Ok();
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        [GearExists]
        public IActionResult Delete(int id)
        {
            service.DeleteGear(id);
            return Ok();
        }
    }
}
