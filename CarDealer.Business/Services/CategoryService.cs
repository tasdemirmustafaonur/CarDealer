using CarDealer.Business.DataTransferObjects;
using CarDealer.Business.Interfaces;
using CarDealer.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CarDealer.Business.Extensions;
using CarDealer.Models;

namespace CarDealer.Business.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository categoryRepository;
        private IMapper mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        public int AddCategory(AddNewCategoryRequest request)
        {
            var newCategory = request.ConvertToCategory(mapper);
            categoryRepository.Add(newCategory);
            return newCategory.Id;
        }

        public void DeleteCategory(int id)
        {
            Category category = categoryRepository.GetById(id);
            category.IsDeleted = true;
            categoryRepository.Update(category);
        }

        public IList<CategoryListResponse> GetAllCategories()
        {
            var dtoList = categoryRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
            
        }

        public CategoryListResponse GetCategoryById(int id)
        {
            Category category = categoryRepository.GetById(id);
            return category.ConvertFromEntity(mapper);
        }

        public int UpdateCategory(EditCategoryRequest request)
        {
            var category = request.ConvertToEntity(mapper);
            int id = categoryRepository.Update(category).Id;
            return id;
        }
    }
}
