﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Business.DataTransferObjects;

namespace CarDealer.Business.Interfaces
{
    public interface IColorService
    {
        IList<ColorListResponse> GetAllColors();
    }
}
