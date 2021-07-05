using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CarDealer.API.Filters
{
    public class RoleExistsAttribute : TypeFilterAttribute
    {
        public RoleExistsAttribute() : base(typeof(RoleExistingFilter))
        {

        }

        private class RoleExistingFilter : IAsyncActionFilter
        {
            private IRoleService roleService;

            public RoleExistingFilter(IRoleService roleService)
            {
                this.roleService = roleService;
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

                var category = roleService.GetRoleById(id);
                if (category == null)
                {
                    context.Result = new NotFoundObjectResult(new { Message = $"{id} nolu rol bulunamadı." });
                    return;
                }

                await next();
            }
        }
    }
}
