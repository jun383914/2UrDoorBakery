using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2UrDoorBakery.Models
{
    public class BakeryRepository : IBakeryRepository
    {
        private readonly IBakeryRepository _bakeryRepository;

        public BakeryRepository(IBakeryRepository bakeryRepository)
        {
            _bakeryRepository = bakeryRepository;
        }

        public IEnumerable<Bakery> GetBakeryByName(string name)
        {
            var query = from r in 
                        where r.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby r.Name
                        select r;
            return query;
        }
        

        public Bakery GetBakeryById(int BakeryId)
        {
            throw new NotImplementedException();
        }
    }
}
