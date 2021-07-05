using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CarDealer.Business.DataTransferObjects;
using CarDealer.Business.Extensions;
using CarDealer.Business.Interfaces;
using CarDealer.DataAccess.Interfaces;
using CarDealer.Models;

namespace CarDealer.Business.Services
{
    public class BrandService : IBrandService
    {
        private IBrandRepository brandRepository;
        private IMapper mapper;

        public BrandService(IBrandRepository brandRepository, IMapper mapper)
        {
            this.brandRepository = brandRepository;
            this.mapper = mapper;
        }

        public int AddBrand(AddNewBrandRequest request)
        {
            var newBrand = request.ConvertToBrand(mapper);
            brandRepository.Add(newBrand);
            return newBrand.Id;
        }

        public void DeleteCategory(int id)
        {
            Brand brand = brandRepository.GetById(id);
            brand.IsDeleted = true;
            brandRepository.Update(brand);
        }

        public IList<BrandListResponse> GetBrandsWithList(List<int> brandList)
        {
            var dtoList = brandRepository.GetBrandsWithList(brandList).ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }

        public IList<BrandListResponse> GetAllBrands()
        {
            var dtoList = brandRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }

        public BrandListResponse GetBrandById(int id)
        
        {
            Brand brand = brandRepository.GetById(id);
            return brand.ConvertFromEntity(mapper);
        }

        public int UpdateBrand(EditBrandRequest request)
        {
            var brand = request.ConvertToEntity(mapper);
            int id = brandRepository.Update(brand).Id;
            return id;
        }
    }
}
