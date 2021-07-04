﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    public class Town : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public bool IsDeleted { get; set; }

    }
}
