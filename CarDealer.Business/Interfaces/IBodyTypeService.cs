using CarDealer.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.Interfaces
{
    public interface IBodyTypeService
    {
        IList<BodyTypeListResponse> GetAllBodyTypes();
        BodyTypeListResponse GetBodyTypeById(int id);
        int AddBodyType(AddNewBodyTypeRequest request);
        int UpdateBodyType(EditBodyTypeRequest request);
        void DeleteBodyType(int id);

    }
}
