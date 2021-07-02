using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CarDealer.API.Filters
{
    public class BrandExistsAttribute : TypeFilterAttribute
    {
        public BrandExistsAttribute():base(typeof(BrandExistingFilter))
        {
            
        }

        private class BrandExistingFilter : IAsyncActionFilter
        {
            private IBrandService brandService;

            public BrandExistingFilter(IBrandService brandService)
            {
                this.brandService = brandService;
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

                var category = brandService.GetBrandById(id);
                if (category == null)
                {
                    context.Result = new NotFoundObjectResult(new { Message = $"{id} nolu marka bulunamadı." });
                    return;
                }

                await next();
            }
        }
    }
}
