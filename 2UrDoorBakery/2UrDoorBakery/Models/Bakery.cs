﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2UrDoorBakery.Models
{
    public class Bakery
    {
        public int BakeryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageThumbnailUrl { get; set; }

    }
}
