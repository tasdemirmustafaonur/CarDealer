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
    public class WheelDriveService : IWheelDriveService
    {
        private IWheelDriveRepository wheelDriveRepository;
        private IMapper mapper;

        public WheelDriveService(IWheelDriveRepository wheelDriveRepository,IMapper mapper)
        {
            this.wheelDriveRepository = wheelDriveRepository;
            this.mapper = mapper;
        }
        public IList<WheelDriveListResponse> GetAllWheelDrives()
        {
            var dtoList = wheelDriveRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }

        public WheelDriveListResponse GetWheelDriveById(int id)
        {
            WheelDrive wheelDrive = wheelDriveRepository.GetById(id);
            return wheelDrive.ConvertFromEntity(mapper);
        }
    }
}
