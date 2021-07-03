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
    public class WheelDrivesController : ControllerBase
    {
        private IWheelDriveService service;

        public WheelDrivesController(IWheelDriveService wheelDriveService)
        {
            service = wheelDriveService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetAllWheelDrives();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var wheelDriveListResponse = service.GetWheelDriveById(id);
            if (wheelDriveListResponse != null)
            {
                return Ok(wheelDriveListResponse);
            }

            return NotFound();
        }


    }
}
