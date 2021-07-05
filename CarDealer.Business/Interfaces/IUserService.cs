using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Business.DataTransferObjects;

namespace CarDealer.Business.Interfaces
{
    public interface IUserService
    {
        IList<UserListResponse> GetAllUsers();
        UserListResponse GetUserById(int id);
        int AddUser(AddNewUserRequest request);
        int UpdateUser(EditUserRequest request);
        void DeleteUser(int id);
    }
}
