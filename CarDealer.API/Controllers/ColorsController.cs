using CarDealer.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using CarDealer.API.Filters;
using CarDealer.Business.DataTransferObjects;

namespace CarDealer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private IColorService service;

        public ColorsController(IColorService colorService)
        {
            service = colorService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetAllColors();
            return Ok(result);
        }

        [HttpGet("{id}")]
        [ColorExists]
        public IActionResult GetById(int id)
        {
            var colorListResponse = service.GetColorById(id);
            if (colorListResponse != null)
            {
                return Ok(colorListResponse);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult AddColors(AddNewColorRequest request)
        {
            if (ModelState.IsValid)
            {
                int colorId = service.AddColor(request);
                return CreatedAtAction(nameof(GetById), routeValues: new {id = colorId}, value: null);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        [ColorExists]
        public IActionResult UpdateColor(int id, EditColorRequest request)
        {
            if (ModelState.IsValid)
            {
                int newItemId = service.UpdateColor(request);
                return Ok();
            }

            return BadRequest(ModelState);
        }

    }
}
