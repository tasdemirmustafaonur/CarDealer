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
    public class ImagesController : ControllerBase
    {
        private IImageService service;

        public ImagesController(IImageService imageService)
        {
            service = imageService;
        }
    }
}
