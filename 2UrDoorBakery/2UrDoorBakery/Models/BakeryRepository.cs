using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2UrDoorBakery.Models
{
    public class BakeryRepository : IBakeryRepository
    {
        //This repository will work with my DbContext
        private readonly BakeryDbContext _bakerydbContext;

        public BakeryRepository(BakeryDbContext bakerydbContext)
        {
            _bakerydbContext = bakerydbContext;
        }

        public IEnumerable<Bakery> AllBakery
        {
            get
            {
                return _bakerydbContext.Bakery;
            }
        }


        public Bakery GetBakeryById(int bakeryId)
        {
            return _bakerydbContext.Bakery.FirstOrDefault(p => p.BakeryId == bakeryId);
        }
    }
}
