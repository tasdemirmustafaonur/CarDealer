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
    public class BodyTypesController : ControllerBase
    {
        private IBodyTypeService service;

        public BodyTypesController(IBodyTypeService bodyTypeService)
        {
            service = bodyTypeService;
        }
    }
}
