using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.API.Filters;
using CarDealer.Business.DataTransferObjects;
using CarDealer.Business.Interfaces;

namespace CarDealer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private ISeriesService service;

        public SeriesController(ISeriesService seriesService)
        {
            service = seriesService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetAllSeries();
            return Ok(result);
        }

        [HttpGet("{id}")]
        [SeriesExists]
        public IActionResult GetById(int id)
        {
            var seriesListResponse = service.GetSeriesById(id);
            if (seriesListResponse != null)
            {
                return Ok(seriesListResponse);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult AddSeries(AddNewSeriesRequest request)
        {
            if (ModelState.IsValid)
            {
                int seriesId = service.AddSeries(request);
                return CreatedAtAction(nameof(GetById), routeValues: new {id = seriesId}, value: null);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        [SeriesExists]
        public IActionResult UpdateSeries(int id, EditSeriesRequest request)
        {
            if (ModelState.IsValid)
            {
                int newItemId = service.UpdateSeries(request);
                return Ok();
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        [SeriesExists]
        public IActionResult Delete(int id)
        {
            service.DeleteSeries(id);
            return Ok();
        }


    }
}
