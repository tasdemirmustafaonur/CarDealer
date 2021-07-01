using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CarDealer.Business.DataTransferObjects;
using CarDealer.Models;

namespace CarDealer.Business.Extensions
{
    public static class Converters
    {
        public static List<CategoryListResponse> ConvertToListResponse(this List<Category> categories, IMapper mapper)
        {
            //var result = new List<CategoryListResponse>();
            //categories.ForEach(x=>result.Add(new CategoryListResponse
            //{
            //    Id=x.Id,
            //    Name = x.Name
            //}));

            //return result;

            return mapper.Map<List<CategoryListResponse>>(categories);
        }

        public static Category ConvertToCategory(this AddNewCategoryRequest request, IMapper mapper)
        {
            return mapper.Map<Category>(request);
        }

        public static CategoryListResponse ConvertFromEntity(this Category category, IMapper mapper)
        {
            return mapper.Map<CategoryListResponse>(category);
        }

        public static Category ConvertToEntity(this EditCategoryRequest request, IMapper mapper)
        {
            return mapper.Map<Category>(request);
        }
    }
}
