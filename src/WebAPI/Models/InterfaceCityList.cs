﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public interface InterfaceCityList
    {
        void Add(City item);
        IEnumerable<City> Get();
    }
}
