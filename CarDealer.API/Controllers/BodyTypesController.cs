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

        [HttpPost]
        public IActionResult AddBodyTypes(AddNewBodyTypeRequest request)
        {
            if (ModelState.IsValid)
            {
                int bodyTypeId = service.AddBodyType(request);
                return CreatedAtAction(nameof(GetById), routeValues: new {id = bodyTypeId}, value: null);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        [BodyTypeExists]
        public IActionResult UpdateBodyType(int id, EditBodyTypeRequest request)
        {
            if (ModelState.IsValid)
            {
                int newItemId = service.UpdateBodyType(request);
                return Ok();
            }

            return BadRequest(ModelState);
        }
    }
}
