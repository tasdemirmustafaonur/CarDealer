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

            CreateMap<Brand, BrandListResponse>().ReverseMap();
            CreateMap<Brand, AddNewBrandRequest>().ReverseMap();
            CreateMap<Brand, EditBrandRequest>().ReverseMap();

            CreateMap<CategoryBrand, CategoryBrandListResponse>().ReverseMap();

            CreateMap<BodyType, BodyTypeListResponse>().ReverseMap();
            CreateMap<BodyType, AddNewBodyTypeRequest>().ReverseMap();
            CreateMap<BodyType, EditBodyTypeRequest>().ReverseMap();

            CreateMap<Fuel, FuelListResponse>().ReverseMap();
            CreateMap<Fuel, AddNewFuelRequest>().ReverseMap();
            CreateMap<Fuel, EditFuelRequest>().ReverseMap();

            CreateMap<Gear, GearListResponse>().ReverseMap();
            CreateMap<Gear, AddNewGearRequest>().ReverseMap();
            CreateMap<Gear, EditGearRequest>().ReverseMap();

            CreateMap<WheelDrive, WheelDriveListResponse>().ReverseMap();
            CreateMap<WheelDrive, AddNewWheelDriveRequest>().ReverseMap();
            CreateMap<WheelDrive, EditWheelDriveRequest>().ReverseMap();

            CreateMap<Color, ColorListResponse>().ReverseMap();
            CreateMap<Color, AddNewColorRequest>().ReverseMap();
            CreateMap<Color, EditColorRequest>().ReverseMap();

            CreateMap<Series, SeriesListResponse>().ReverseMap();
            CreateMap<Series, AddNewSeriesRequest>().ReverseMap();
            CreateMap<Series, EditSeriesRequest>().ReverseMap();

            CreateMap<Model, ModelListResponse>().ReverseMap();
            CreateMap<Model, AddNewModelRequest>().ReverseMap();
            CreateMap<Model, EditModelRequest>().ReverseMap();

            CreateMap<City, CityListResponse>().ReverseMap();
            CreateMap<City, AddNewCityRequest>().ReverseMap();
            CreateMap<City, EditCityRequest>().ReverseMap();

        }
    }
}
