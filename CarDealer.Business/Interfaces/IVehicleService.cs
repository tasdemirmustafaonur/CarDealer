using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Business.DataTransferObjects;
using CarDealer.Models;

namespace CarDealer.Business.Interfaces
{
    public interface IVehicleService
    {
        IList<Vehicle> GetAllVehicles();
    }
}
