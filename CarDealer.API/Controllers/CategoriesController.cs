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
    public class CategoriesController : ControllerBase
    {
        private ICategoryService service;
        public CategoriesController(ICategoryService categoryService)
        {
            service = categoryService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetAllCategories();
            return Ok(result);
        }

        [HttpGet("{id}")]
        [CategoryExists]
        public IActionResult GetById(int id)
        {
            var categoryListResponse = service.GetCategoryById(id);
            if (categoryListResponse != null)
            {
                return Ok(categoryListResponse);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddCategories(AddNewCategoryRequest request)
        {
            if (ModelState.IsValid)
            {
                int categoryId = service.AddCategory(request);
                return CreatedAtAction(nameof(GetById), routeValues: new {id = categoryId}, value: null);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        [CategoryExists]
        public IActionResult UpdateCategory(int id, EditCategoryRequest request)
        {
            //Aşağıdaki işlemi [GenreExists] yapıyor. Detaylar Filters'da
            //var isExisting = service.GetCategoryById(id);
            //if (isExisting == null)
            //{
            //    return NotFound();
            //}
            if (ModelState.IsValid)
            {
                int newItemId = service.UpdateCategory(request);
                return Ok();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        [CategoryExists]
        public IActionResult Delete(int id)
        {
            service.DeleteCategory(id);

            return Ok();
        }
    }
}
