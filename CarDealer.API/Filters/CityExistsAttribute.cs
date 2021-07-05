using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CarDealer.API.Filters
{
    public class CityExistsAttribute : TypeFilterAttribute
    {
        public CityExistsAttribute() : base(typeof(CityExistingFilter))
        {

        }

        private class CityExistingFilter : IAsyncActionFilter
        {
            private ICityService cityService;

            public CityExistingFilter(ICityService cityService)
            {
                this.cityService = cityService;
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

                var category = cityService.GetCityById(id);
                if (category == null)
                {
                    context.Result = new NotFoundObjectResult(new { Message = $"{id} nolu şehir bulunamadı." });
                    return;
                }

                await next();
            }
        }
    }
}
