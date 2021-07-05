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
    public class ImagesController : ControllerBase
    {
        private IImageService service;

        public ImagesController(IImageService imageService)
        {
            service = imageService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetAllImages();
            return Ok(result);
        }

        [HttpGet("{id}")]
        [ImageExists]
        public IActionResult GetById(int id)
        {
            var imageListResponse = service.GetImageById(id);
            if (imageListResponse != null)
            {
                return Ok(imageListResponse);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult AddImages(AddNewImageRequest request)
        {
            if (ModelState.IsValid)
            {
                int imageId = service.AddImage(request);
                return CreatedAtAction(nameof(GetById), routeValues: new {id = imageId}, value: null);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        [ImageExists]
        public IActionResult UpdateImage(int id, EditImageRequest request)
        {
            if (ModelState.IsValid)
            {
                int newItemId = service.UpdateImage(request);
                return Ok();
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        [ImageExists]
        public IActionResult Delete(int id)
        {
            service.DeleteImage(id);
            return Ok();
        }

    }
}
