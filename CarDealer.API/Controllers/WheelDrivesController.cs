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
        [WheelDriveExists]
        public IActionResult GetById(int id)
        {
            var wheelDriveListResponse = service.GetWheelDriveById(id);
            if (wheelDriveListResponse != null)
            {
                return Ok(wheelDriveListResponse);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult AddWheelDrives(AddNewWheelDriveRequest request)
        {
            if (ModelState.IsValid)
            {
                int wheelDriveId = service.AddWheelDrive(request);
                return CreatedAtAction(nameof(GetById), routeValues: new {id = wheelDriveId}, value: null);
            }

            return BadRequest(ModelState);
        }

        


    }
}
