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
    public class ModelsController : ControllerBase
    {
        private IModelService service;
        public ModelsController(IModelService modelService)
        {
            service = modelService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetAllModels();
            return Ok(result);
        }

        [HttpGet("{id}")]
        [ModelExists]
        public IActionResult GetById(int id)
        {
            var modelListResponse = service.GetModelById(id);
            if (modelListResponse != null)
            {
                return Ok(modelListResponse);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult AddModels(AddNewModelRequest request)
        {
            if (ModelState.IsValid)
            {
                int modelId = service.AddModel(request);
                return CreatedAtAction(nameof(GetById), routeValues: new {id = modelId}, value: null);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        [ModelExists]
        public IActionResult UpdateModel(int id, EditModelRequest request)
        {
            if (ModelState.IsValid)
            {
                int newItemId = service.UpdateModel(request);
                return Ok();
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        [ModelExists]
        public IActionResult Delete(int id)
        {
            service.DeleteModel(id);
            return Ok();
        }
    }
}
