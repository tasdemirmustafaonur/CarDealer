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
    }
}
