using CarDealer.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.Interfaces
{
    public interface IBrandService
    {
        IList<BrandListResponse> GetAllBrands();
        int AddBrand(AddNewBrandRequest request);
        BrandListResponse GetBrandById(int id);
        int UpdateBrand(EditBrandRequest request);
        void DeleteCategory(int id);
        IList<BrandListResponse> GetBrandsWithList(List<int> brandList);
    }
}
