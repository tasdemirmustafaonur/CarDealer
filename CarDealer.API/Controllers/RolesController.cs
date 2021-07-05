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
    public class RolesController : ControllerBase
    {
        private IRoleService service;

        public RolesController(IRoleService roleService)
        {
            service = roleService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetAllRoles();
            return Ok(result);
        }

        [HttpGet("{id}")]
        [RoleExists]
        public IActionResult GetById(int id)
        {
            var roleListResponse = service.GetRoleById(id);
            if (roleListResponse != null)
            {
                return Ok(roleListResponse);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult AddRoles(AddNewRoleRequest request)
        {
            if (ModelState.IsValid)
            {
                int roleId = service.AddRole(request);
                return CreatedAtAction(nameof(GetById), routeValues: new {id = roleId}, value: null);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        [RoleExists]
        public IActionResult UpdateRole(int id, EditRoleRequest request)
        {
            if (ModelState.IsValid)
            {
                int newItemId = service.UpdateRole(request);
                return Ok();
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        [RoleExists]
        public IActionResult Delete(int id)
        {
            service.DeleteRole(id);
            return Ok();
        }
    }
}
