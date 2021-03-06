﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2UrDoorBakery.Models
{
    public interface IBakeryRepository
    {
        public IEnumerable<Bakery> AllBakery { get; }
        Bakery GetBakeryById(int bakeryId);
    }
}
