using CarDealer.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.API.Filters;

namespace CarDealer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodyTypesController : ControllerBase
    {
        private IBodyTypeService service;

        public BodyTypesController(IBodyTypeService bodyTypeService)
        {
            service = bodyTypeService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = service.GetAllBodyTypes();
            return Ok(result);
        }

        [HttpGet("{id}")]
        [BodyTypeExists]
        public IActionResult GetById(int id)
        {
            var bodyTypeListResponse = service.GetBodyTypeById(id);
            if (bodyTypeListResponse != null)
            {
                return Ok(bodyTypeListResponse);
            }

            return NotFound();
        }
    }
}
