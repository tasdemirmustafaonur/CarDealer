using CarDealer.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.Interfaces
{
    public interface IWheelDriveService
    {
        IList<WheelDriveListResponse> GetAllWheelDrives();
    }
}
