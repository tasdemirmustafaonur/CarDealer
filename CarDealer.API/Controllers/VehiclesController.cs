﻿using CarDealer.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public IActionResult GetById(int id)
        {
            var vehicleListResponse = service.GetVehicleById(id);
            if (vehicleListResponse != null)
            {
                return Ok(vehicleListResponse);
            }

            return NotFound();
        }

        [HttpPut]
        public IActionResult AddVehicle(AddNewVehicleRequest request)
        {

        }

    }
}
