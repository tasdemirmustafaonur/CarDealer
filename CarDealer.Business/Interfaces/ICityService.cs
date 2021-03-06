using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Business.DataTransferObjects;

namespace CarDealer.Business.Interfaces
{
    public interface ICityService
    {
        IList<CityListResponse> GetAllCities();
        CityListResponse GetCityById(int id);
        int AddCity(AddNewCityRequest request);
        int UpdateCity(EditCityRequest request);
        void DeleteCity(int id);
    }
}
