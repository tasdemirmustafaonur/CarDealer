using CarDealer.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.Interfaces
{
    public interface IGearService
    {
        IList<GearListResponse> GetAllGears();
        GearListResponse GetGearById(int id);
        int AddGear(AddNewGearRequest request);
        int UpdateGear(EditGearRequest request);
        void DeleteGear(int id);
    }
}
