using CarDealer.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.Interfaces
{
    public interface ICategoryBrandService 
    {
        IList<CategoryBrandListResponse> GetAllCategoryBrands();

        IList<CategoryBrandListResponse> GetCategoryBrandsByCategoryId(int categoryId);
        //List<int> brandList = _categoryBrandService.GetByCategoryId(categoryId).Select(x => x.BrandId);
    }
}
