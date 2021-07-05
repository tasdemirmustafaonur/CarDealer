using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CarDealer.API.Filters
{
    public class VehicleExistsAttribute : TypeFilterAttribute
    {
        public VehicleExistsAttribute() : base(typeof(VehicleExistingFilter))
        {

        }

        private class VehicleExistingFilter : IAsyncActionFilter
        {
            private IVehicleService vehicleService;

            public VehicleExistingFilter(IVehicleService vehicleService)
            {
                this.vehicleService = vehicleService;
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

                var category = vehicleService.GetVehicleById(id);
                if (category == null)
                {
                    context.Result = new NotFoundObjectResult(new { Message = $"{id} nolu araba bulunamadı." });
                    return;
                }

                await next();
            }
        }
    }
}
