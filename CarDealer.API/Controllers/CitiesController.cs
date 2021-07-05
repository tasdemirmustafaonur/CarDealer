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

        [HttpGet("{id}")]
        [CityExists]
        public IActionResult GetById(int id)
        {
            var cityListResponse = service.GetCityById(id);
            if (cityListResponse != null)
            {
                return Ok(cityListResponse);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult AddCities(AddNewCityRequest request)
        {
            if (ModelState.IsValid)
            {
                int cityId = service.AddCity(request);
                return CreatedAtAction(nameof(GetById), routeValues: new {id = cityId}, value: null);
            }

            return BadRequest(ModelState);
        }


        public IActionResult UpdateCity(int id, EditCityRequest request)
        {

        }
    }
}
