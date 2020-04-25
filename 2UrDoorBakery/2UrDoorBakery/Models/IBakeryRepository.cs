using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2UrDoorBakery.Models
{
    public interface IBakeryRepository
    {
        IEnumerable<Bakery> GetBakeryByName { get;}
        Bakery GetBakeryById(int BakeryId);
    }
}
