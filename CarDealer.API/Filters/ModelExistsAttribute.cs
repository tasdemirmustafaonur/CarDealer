using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CarDealer.API.Filters
{
    public class ModelExistsAttribute : TypeFilterAttribute
    {
        public ModelExistsAttribute() : base(typeof(ModelExistingFilter))
        {

        }

        private class ModelExistingFilter : IAsyncActionFilter
        {
            private IModelService modelService;

            public ModelExistingFilter(IModelService modelService)
            {
                this.modelService = modelService;
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

                var category = modelService.GetModelById(id);
                if (category == null)
                {
                    context.Result = new NotFoundObjectResult(new { Message = $"{id} nolu tür bulunamadı." });
                    return;
                }

                await next();
            }
        }
    }
}
