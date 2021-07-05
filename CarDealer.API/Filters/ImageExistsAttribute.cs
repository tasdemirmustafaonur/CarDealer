using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CarDealer.API.Filters
{
    public class ImageExistsAttribute : TypeFilterAttribute
    {
        public ImageExistsAttribute() : base(typeof(ImageExistingFilter))
        {

        }

        private class ImageExistingFilter : IAsyncActionFilter
        {
            private IImageService imageService;

            public ImageExistingFilter(IImageService imageService)
            {
                this.imageService = imageService;
            }
            public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
            {
                if (!context.ActionArguments.ContainsKey("id"))
                {
                    context.Result = new BadRequestResult();
                    return;
                }

                if (!(context.ActionArguments["id"] is int id))
                {
                    context.Result = new BadRequestResult();
                    return;
                }

                var category = imageService.GetImageById(id);
                if (category == null)
                {
                    context.Result = new NotFoundObjectResult(new { Message = $"{id} nolu resim bulunamadı." });
                    return;
                }

                await next();
            }
        }
    }
}
