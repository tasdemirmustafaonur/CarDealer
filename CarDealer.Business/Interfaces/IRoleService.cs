using CarDealer.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.Interfaces
{
    public interface IRoleService
    {
        IList<RoleListResponse> GetAllRoles();
        RoleListResponse GetRoleById(int id);
        int AddRole(AddNewRoleRequest request);
        int UpdateRole(EditRoleRequest request);
    }
}
