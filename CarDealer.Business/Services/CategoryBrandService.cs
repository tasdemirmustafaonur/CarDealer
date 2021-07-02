using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CarDealer.Business.DataTransferObjects;
using CarDealer.Business.Extensions;
using CarDealer.Business.Interfaces;
using CarDealer.DataAccess.Interfaces;

namespace CarDealer.Business.Services
{
    public class CategoryBrandService : ICategoryBrandService
    {
        private ICategoryBrandRepository categoryBrandRepository;
        private IMapper mapper;

        public CategoryBrandService(ICategoryBrandRepository categoryBrandRepository, IMapper mapper)
        {
            this.categoryBrandRepository = categoryBrandRepository;
            this.mapper = mapper;
        }
        public IList<CategoryBrandListResponse> GetAllCategoryBrands()
        {
            var dtoList = categoryBrandRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }

        public IList<CategoryBrandListResponse> GetCategoryBrandsByCategoryId(int categoryId)
        {
            var dtoList = categoryBrandRepository.getCategoryBrandsByCategoryId(categoryId).ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }
    }
}
