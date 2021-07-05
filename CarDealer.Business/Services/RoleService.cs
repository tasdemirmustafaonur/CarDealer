﻿using System;
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
    public class RoleService : IRoleService
    {
        private IRoleRepository roleRepository;
        private IMapper mapper;

        public RoleService(IRoleRepository roleRepository, IMapper mapper)
        {
            this.roleRepository = roleRepository;
            this.mapper = mapper;
        }
        public IList<RoleListResponse> GetAllRoles()
        {
            var dtoList = roleRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }

        public RoleListResponse GetRoleById(int id)
        {
            Role role = roleRepository.GetById(id);
            return role.ConvertFromEntity(mapper);
        }
    }
}
