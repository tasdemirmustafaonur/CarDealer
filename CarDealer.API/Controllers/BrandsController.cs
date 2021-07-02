using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using CarDealer.API.Filters;
using CarDealer.Business.DataTransferObjects;
using CarDealer.Business.Interfaces;

namespace CarDealer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService service;
        private readonly ICategoryBrandService _categoryBrandService;

        public BrandsController(IBrandService brandService, ICategoryBrandService categoryBrandService)
        {
            service = brandService;
            _categoryBrandService = categoryBrandService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetAllBrands();
            return Ok(result);
        }

        [HttpGet("{id}")]
        [BrandExists]
        public IActionResult GetById(int id)
        {
            var brandListResponse = service.GetBrandById(id);
            if (brandListResponse != null)
            {
                return Ok(brandListResponse);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult AddBrands(AddNewBrandRequest request)
        {
            if (ModelState.IsValid)
            {
                int brandId = service.AddBrand(request);
                return CreatedAtAction(nameof(GetById), routeValues: new {id = brandId}, value: null);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        [BrandExists]
        public IActionResult UpdateBrand(int id, EditBrandRequest request)
        {
            if (ModelState.IsValid)
            {
                int newItemId = service.UpdateBrand(request);
                return Ok();
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        [BrandExists]
        public IActionResult Delete(int id)
        {
            service.DeleteCategory(id);
            return Ok();
        }

        [HttpGet("categorybrand/{categoryId}")]
        public IActionResult GetBrandWithCategoryId(int categoryId)
        {
            List<int> brandList = _categoryBrandService.GetCategoryBrandsByCategoryId(categoryId).Select(x=> x.BrandId).ToList();

            var brandListResponse = service.GetBrandsWithList(brandList);
            if (brandListResponse != null)
            {
                return Ok(brandListResponse);
            }

            return NotFound();
        }
    }
}
