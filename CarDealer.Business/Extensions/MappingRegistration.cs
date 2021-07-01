using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Business.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace CarDealer.Business.Extensions
{
    public static class MappingRegistration
    {
        public static IServiceCollection AddMapperConfiguration(this IServiceCollection services)
        {
            return services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
