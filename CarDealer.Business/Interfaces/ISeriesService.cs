using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Business.DataTransferObjects;

namespace CarDealer.Business.Interfaces
{
    public interface ISeriesService
    {
        IList<SeriesListResponse> GetAllSeries();
        SeriesListResponse GetSeriesById(int id);
        int AddSeries(AddNewSeriesRequest request);
        int UpdateSeries(EditSeriesRequest request);
        void DeleteSeries(int id);
    }
}
