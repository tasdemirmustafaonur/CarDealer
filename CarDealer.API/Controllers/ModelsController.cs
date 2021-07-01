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
    }
}
