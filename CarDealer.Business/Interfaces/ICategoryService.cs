using CarDealer.Business.DataTransferObjects;
using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.Interfaces
{
    public interface ICategoryService
    {
        //Tüm kategorileri getir.
        IList<CategoryListResponse> GetAllCategories();
        //ekllene son varlığın id'si dönecek
        int AddCategory(AddNewCategoryRequest request);
        CategoryListResponse GetCategoryById(int id);
        int UpdateCategory(EditCategoryRequest request);
        void DeleteCategory(int id);
    }
}
