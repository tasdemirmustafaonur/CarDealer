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
    public class TownService : ITownService
    {
        private ITownRepository townRepository;
        private IMapper mapper;

        public TownService(ITownRepository townRepository, IMapper mapper)
        {
            this.townRepository = townRepository;
            this.mapper = mapper;
        }

        public int AddTown(AddNewTownRequest request)
        {
            var newTown = request.ConvertToTown(mapper);
            townRepository.Add(newTown);
            return newTown.Id;
        }

        public void DeleteTown(int id)
        {
            Town town = townRepository.GetById(id);
            town.IsDeleted = true;
            townRepository.Update(town);
        }

        public IList<TownListResponse> GetAllTowns()
        {
            var dtoList = townRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }

        public TownListResponse GetTownById(int id)
        {
            Town town = townRepository.GetById(id);
            return town.ConvertFromEntity(mapper);
        }

        public int UpdateTown(EditTownRequest request)
        {
            var town = request.ConvertToEntity(mapper);
            int id = townRepository.Update(town).Id;
            return id;
        }
    }
}
