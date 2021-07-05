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
    public class RoleService : IRoleService
    {
        private IRoleRepository roleRepository;
        private IMapper mapper;

        public RoleService(IRoleRepository roleRepository, IMapper mapper)
        {
            this.roleRepository = roleRepository;
            this.mapper = mapper;
        }

        public int AddRole(AddNewRoleRequest request)
        {
            var newRole = request.ConvertToRole(mapper);
            roleRepository.Add(newRole);
            return newRole.Id;
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

        public int UpdateRole(EditRoleRequest request)
        {
            var role = request.ConvertToEntity(mapper);
            int id = roleRepository.Update(role).Id;
            return id;
        }
    }
}
