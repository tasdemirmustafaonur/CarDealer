using CarDealer.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;

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
        public IActionResult GetById(int id)
        {
            var colorListResponse = service.GetColorById(id);
            if (colorListResponse != null)
            {
                return Ok(colorListResponse);
            }

            return NotFound();
        }

    }
}
