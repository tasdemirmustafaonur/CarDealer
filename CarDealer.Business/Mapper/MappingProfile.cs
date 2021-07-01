using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CarDealer.Business.DataTransferObjects;
using CarDealer.Models;

namespace CarDealer.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryListResponse>().ReverseMap();
            CreateMap<Category, AddNewCategoryRequest>().ReverseMap();
            CreateMap<Category, EditCategoryRequest>().ReverseMap();
        }
    }
}
