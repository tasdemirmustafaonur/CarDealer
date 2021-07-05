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

        [HttpGet("{id}")]
        [UserExists]
        public IActionResult GetById(int id)
        {
            var userListResponse = service.GetUserById(id);
            if (userListResponse != null)
            {
                return Ok(userListResponse);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult AddUsers(AddNewUserRequest request)
        {
            if (ModelState.IsValid)
            {
                int userId = service.AddUser(request);
                return CreatedAtAction(nameof(GetById), routeValues: new {id = userId}, value: null);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        [UserExists]
        public IActionResult UpdateUser(int id, EditUserRequest request)
        {
            if (ModelState.IsValid)
            {
                int newItemId = service.UpdateUser(request);
                return Ok();
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        [UserExists]
        public IActionResult Delete(int id)
        {
            service.DeleteUser(id);
            return Ok();
        }
    }
}
