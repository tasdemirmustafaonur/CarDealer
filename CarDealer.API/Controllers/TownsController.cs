using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Business.DataTransferObjects;
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

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var townListResponse = service.GetTownById(id);
            if (townListResponse != null)
            {
                return Ok(townListResponse);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult AddTowns(AddNewTownRequest request)
        {
            if (ModelState.IsValid)
            {
                int townId = service.AddTown(request);
                return CreatedAtAction(nameof(GetById), routeValues: new {id = townId}, value: null);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        
        public IActionResult UpdateTown(int id, EditTownRequest request)
        {
            if (ModelState.IsValid)
            {
                int newItemId = service.UpdateTown(request);
                return Ok();
            }

            return BadRequest(ModelState);
        }

    }
}
