using System;
using System.Collections.Generic;
using System.Linq;
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
    public class SeriesService : ISeriesService
    {
        private ISeriesRepository seriesRepository;
        private IMapper mapper;

        public SeriesService(ISeriesRepository seriesRepository,IMapper mapper)
        {
            this.seriesRepository = seriesRepository;
            this.mapper = mapper;
        }
        public IList<SeriesListResponse> GetAllSeries()
        {
            var dtoList = seriesRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }

        public SeriesListResponse GetSeriesById(int id)
        {
            Series series = seriesRepository.GetById(id);
            return series.ConvertFromEntity(mapper);
        }
    }
}
