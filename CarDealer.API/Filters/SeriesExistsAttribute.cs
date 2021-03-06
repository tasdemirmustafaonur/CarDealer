using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CarDealer.API.Filters
{
    public class SeriesExistsAttribute : TypeFilterAttribute
    {
        public SeriesExistsAttribute() : base(typeof(SeriesExistingFilter))
        {

        }

        private class SeriesExistingFilter : IAsyncActionFilter
        {
            private ISeriesService seriesService;

            public SeriesExistingFilter(ISeriesService seriesService)
            {
                this.seriesService = seriesService;
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

                var category = seriesService.GetSeriesById(id);
                if (category == null)
                {
                    context.Result = new NotFoundObjectResult(new { Message = $"{id} nolu seri bulunamadı." });
                    return;
                }

                await next();
            }
        }
    }
}
