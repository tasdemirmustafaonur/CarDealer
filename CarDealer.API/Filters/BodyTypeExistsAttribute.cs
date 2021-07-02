using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CarDealer.API.Filters
{
    public class BodyTypeExistsAttribute : TypeFilterAttribute
    {
        public BodyTypeExistsAttribute():base(typeof(BodyTypeExistingFilter))
        {
            
        }

        private class BodyTypeExistingFilter : IAsyncActionFilter
        {
            private IBodyTypeService bodyTypeService;

            public BodyTypeExistingFilter(IBodyTypeService bodyTypeService)
            {
                this.bodyTypeService = bodyTypeService;
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
                    ;
                }

                var bodyType = bodyTypeService.GetBodyTypeById(id);
                if (bodyType == null)
                {
                    context.Result = new NotFoundObjectResult(new {Message = $"{id} nolu kasa tipi bulunamadı"});
                    return;
                }

                await next();
            }
        }
    }
}
