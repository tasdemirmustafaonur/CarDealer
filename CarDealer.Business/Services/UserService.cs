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
    public class UserService : IUserService
    {
        private IUserRepository userRepository;
        private IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public IList<UserListResponse> GetAllUsers()
        {
            var dtoList = userRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }

        public UserListResponse GetUserById(int id)
        {
            User user = userRepository.GetById(id);
            return user.ConvertFromEntity(mapper);
        }

        public int AddUser(AddNewUserRequest request)
        {
            var newUser = request.ConvertToUser(mapper);
            userRepository.Add(newUser);
            return newUser.Id;
        }

        public int UpdateUser(EditUserRequest request)
        {
            var user = request.ConvertToEntity(mapper);
            int id = userRepository.Update(user).Id;
            return id;
        }

        public void DeleteUser(int id)
        {
            User user = userRepository.GetById(id);
            user.IsDeleted = true;
            userRepository.Update(user);
        }
    }
}
