using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Business.DataTransferObjects;

namespace CarDealer.Business.Interfaces
{
    public interface ITownService
    {
        IList<TownListResponse> GetAllTowns();
        TownListResponse GetTownById(int id);
        int AddTown(AddNewTownRequest request);
    }
}
