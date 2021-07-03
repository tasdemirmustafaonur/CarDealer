using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CarDealer.API.Filters
{
    public class WheelDriveExistsAttribute : TypeFilterAttribute
    {
        public WheelDriveExistsAttribute() : base(typeof(WheelDriveExistingFilter))
        {

        }

        private class WheelDriveExistingFilter : IAsyncActionFilter
        {
            private IWheelDriveService wheelDriveService;

            public WheelDriveExistingFilter(IWheelDriveService wheelDriveService)
            {
                this.wheelDriveService = wheelDriveService;
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

                var category = wheelDriveService.GetWheelDriveById(id);
                if (category == null)
                {
                    context.Result = new NotFoundObjectResult(new { Message = $"{id} nolu çekiş türü bulunamadı." });
                    return;
                }

                await next();
            }
        }
    }
}
