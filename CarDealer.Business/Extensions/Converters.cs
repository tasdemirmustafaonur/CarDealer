﻿using System;
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
        //       CONVERT TO LİST RESPONSE

        public static List<CategoryListResponse> ConvertToListResponse(this List<Category> categories, IMapper mapper)
        {
            return mapper.Map<List<CategoryListResponse>>(categories);
        }

        public static List<BrandListResponse> ConvertToListResponse(this List<Brand> brands, IMapper mapper)
        {
            return mapper.Map<List<BrandListResponse>>(brands);
        }

        public static List<CategoryBrandListResponse> ConvertToListResponse(this List<CategoryBrand> categoryBrands, IMapper mapper)
        {
            return mapper.Map<List<CategoryBrandListResponse>>(categoryBrands);
        }

        public static List<BodyTypeListResponse> ConvertToListResponse(this List<BodyType> bodyTypes, IMapper mapper)
        {
            return mapper.Map<List<BodyTypeListResponse>>(bodyTypes);
        }

        //       ADD NEW ENTİTY REQUEST

        public static Category ConvertToCategory(this AddNewCategoryRequest request, IMapper mapper)
        {
            return mapper.Map<Category>(request);
        }

        public static Brand ConvertToBrand(this AddNewBrandRequest request, IMapper mapper)
        {
            return mapper.Map<Brand>(request);
        }

        //          CONVERT FROM ENTİTY

        public static CategoryListResponse ConvertFromEntity(this Category category, IMapper mapper)
        {
            return mapper.Map<CategoryListResponse>(category);
        }

        public static BrandListResponse ConvertFromEntity(this Brand brand, IMapper mapper)
        {
            return mapper.Map<BrandListResponse>(brand);
        }

        public static BodyTypeListResponse ConvertFromEntity(this BodyType bodyType, IMapper mapper)
        {
            return mapper.Map<BodyTypeListResponse>(bodyType);
        }

        //         CONVERT TO ENTİY EDİT

        public static Category ConvertToEntity(this EditCategoryRequest request, IMapper mapper)
        {
            return mapper.Map<Category>(request);
        }

        public static Brand ConvertToEntity(this EditBrandRequest request, IMapper mapper)
        {
            return mapper.Map<Brand>(request);
        }

    }
}
