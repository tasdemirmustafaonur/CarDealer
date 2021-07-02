using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CarDealer.API.Filters
{
    public class FuelExistsAttribute : TypeFilterAttribute
    {
        public FuelExistsAttribute() : base(typeof(FuelExistingFilter))
        {

        }

        private class FuelExistingFilter : IAsyncActionFilter
        {
            private IFuelService fuelService;

            public FuelExistingFilter(IFuelService fuelService)
            {
                this.fuelService = fuelService;
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

                var category = fuelService.GetFuelById(id);
                if (category == null)
                {
                    context.Result = new NotFoundObjectResult(new { Message = $"{id} nolu yakıt tipi bulunamadı." });
                    return;
                }

                await next();
            }
        }
    }
}
