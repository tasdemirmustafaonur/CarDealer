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

        public static List<FuelListResponse> ConvertToListResponse(this List<Fuel> fuels, IMapper mapper)
        {
            return mapper.Map<List<FuelListResponse>>(fuels);
        }

        public static List<GearListResponse> ConvertToListResponse(this List<Gear> gears, IMapper mapper)
        {
            return mapper.Map<List<GearListResponse>>(gears);
        }

        public static List<WheelDriveListResponse> ConvertToListResponse(this List<WheelDrive> wheelDrives, IMapper mapper)
        {
            return mapper.Map<List<WheelDriveListResponse>>(wheelDrives);
        }

        public static List<ColorListResponse> ConvertToListResponse(this List<Color> colors, IMapper mapper)
        {
            return mapper.Map<List<ColorListResponse>>(colors);
        }

        public static List<SeriesListResponse> ConvertToListResponse(this List<Series> series, IMapper mapper)
        {
            return mapper.Map<List<SeriesListResponse>>(series);
        }

        public static List<ModelListResponse> ConvertToListResponse(this List<Model> models, IMapper mapper)
        {
            return mapper.Map<List<ModelListResponse>>(models);
        }

        public static List<CityListResponse> ConvertToListResponse(this List<City> cities, IMapper mapper)
        {
            return mapper.Map<List<CityListResponse>>(cities);
        }

        public static List<TownListResponse> ConvertToListResponse(this List<Town> towns, IMapper mapper)
        {
            return mapper.Map<List<TownListResponse>>(towns);
        }

        public static List<ImageListResponse> ConvertToListResponse(this List<Image> images, IMapper mapper)
        {
            return mapper.Map<List<ImageListResponse>>(images);
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

        public static BodyType ConvertToBodyType(this AddNewBodyTypeRequest request, IMapper mapper)
        {
            return mapper.Map<BodyType>(request);
        }

        public static Fuel ConvertToFuel(this AddNewFuelRequest request, IMapper mapper)
        {
            return mapper.Map<Fuel>(request);
        }

        public static Gear ConvertToGear(this AddNewGearRequest request, IMapper mapper)
        {
            return mapper.Map<Gear>(request);
        }

        public static WheelDrive ConvertToWheelDrive(this AddNewWheelDriveRequest request, IMapper mapper)
        {
            return mapper.Map<WheelDrive>(request);
        }

        public static Color ConvertToColor(this AddNewColorRequest request, IMapper mapper)
        {
            return mapper.Map<Color>(request);
        }

        public static Series ConvertToSeries(this AddNewSeriesRequest request, IMapper mapper)
        {
            return mapper.Map<Series>(request);
        }

        public static Model ConvertToModel(this AddNewModelRequest request, IMapper mapper)
        {
            return mapper.Map<Model>(request);
        }

        public static City ConvertToCity(this AddNewCityRequest request, IMapper mapper)
        {
            return mapper.Map<City>(request);
        }

        public static Town ConvertToTown(this AddNewTownRequest request, IMapper mapper)
        {
            return mapper.Map<Town>(request);
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

        public static FuelListResponse ConvertFromEntity(this Fuel fuel, IMapper mapper)
        {
            return mapper.Map<FuelListResponse>(fuel);
        }

        public static GearListResponse ConvertFromEntity(this Gear gear, IMapper mapper)
        {
            return mapper.Map<GearListResponse>(gear);
        }

        public static WheelDriveListResponse ConvertFromEntity(this WheelDrive wheelDrive, IMapper mapper)
        {
            return mapper.Map<WheelDriveListResponse>(wheelDrive);
        }

        public static ColorListResponse ConvertFromEntity(this Color color, IMapper mapper)
        {
            return mapper.Map<ColorListResponse>(color);
        }

        public static SeriesListResponse ConvertFromEntity(this Series series, IMapper mapper)
        {
            return mapper.Map<SeriesListResponse>(series);
        }
        public static ModelListResponse ConvertFromEntity(this Model model, IMapper mapper)
        {
            return mapper.Map<ModelListResponse>(model);
        }

        public static CityListResponse ConvertFromEntity(this City city, IMapper mapper)
        {
            return mapper.Map<CityListResponse>(city);
        }

        public static TownListResponse ConvertFromEntity(this Town town, IMapper mapper)
        {
            return mapper.Map<TownListResponse>(town);
        }

        public static ImageListResponse ConvertFromEntity(this Image image, IMapper mapper)
        {
            return mapper.Map<ImageListResponse>(image);
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

        public static BodyType ConvertToEntity(this EditBodyTypeRequest request, IMapper mapper)
        {
            return mapper.Map<BodyType>(request);
        }

        public static Fuel ConvertToEntity(this EditFuelRequest request, IMapper mapper)
        {
            return mapper.Map<Fuel>(request);
        }

        public static Gear ConvertToEntity(this EditGearRequest request, IMapper mapper)
        {
            return mapper.Map<Gear>(request);
        }

        public static WheelDrive ConvertToEntity(this EditWheelDriveRequest request, IMapper mapper)
        {
            return mapper.Map<WheelDrive>(request);
        }

        public static Color ConvertToEntity(this EditColorRequest request, IMapper mapper)
        {
            return mapper.Map<Color>(request);
        }

        public static Series ConvertToEntity(this EditSeriesRequest request, IMapper mapper)
        {
            return mapper.Map<Series>(request);
        }

        public static Model ConvertToEntity(this EditModelRequest request, IMapper mapper)
        {
            return mapper.Map<Model>(request);
        }
        public static City ConvertToEntity(this EditCityRequest request, IMapper mapper)
        {
            return mapper.Map<City>(request);
        }

        public static Town ConvertToEntity(this EditTownRequest request, IMapper mapper)
        {
            return mapper.Map<Town>(request);
        }

    }
}
