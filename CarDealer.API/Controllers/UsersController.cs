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
    public class UsersController : ControllerBase
    {
        private IUserService service;

        public UsersController(IUserService userService)
        {
            service = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetAllUsers();
            return Ok(result);
        }
    }
}
