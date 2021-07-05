using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CarDealer.API.Filters
{
    public class TownExistsAttribute : TypeFilterAttribute
    {
        public TownExistsAttribute() : base(typeof(TownExistingFilter))
        {

        }

        private class TownExistingFilter : IAsyncActionFilter
        {
            private ITownService townService;

            public TownExistingFilter(ITownService townService)
            {
                this.townService = townService;
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

                var category = townService.GetTownById(id);
                if (category == null)
                {
                    context.Result = new NotFoundObjectResult(new { Message = $"{id} nolu ilçe bulunamadı." });
                    return;
                }

                await next();
            }
        }
    }
}
