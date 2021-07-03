﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CarDealer.API.Filters
{
    public class ColorExistsAttribute : TypeFilterAttribute
    {
        public ColorExistsAttribute() : base(typeof(ColorExistingFilter))
        {

        }

        private class ColorExistingFilter :IAsyncActionFilter
        {
            private IColorService colorService;

            public ColorExistingFilter(IColorService colorService)
            {
                this.colorService = colorService;
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

                var category = colorService.GetColorById(id);
                if (category == null)
                {
                    context.Result = new NotFoundObjectResult(new { Message = $"{id} nolu renk bulunamadı." });
                    return;
                }

                await next();
            }
        }
    }
}
