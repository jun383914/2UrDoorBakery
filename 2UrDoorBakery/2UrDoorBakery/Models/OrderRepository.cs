using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2UrDoorBakery.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BakeryDbContext _bakeryDbContext;

        public OrderRepository(BakeryDbContext bakeryDbContext)
        {
            _bakeryDbContext = bakeryDbContext;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;



            _bakeryDbContext.Orders.Add(order);

            _bakeryDbContext.SaveChanges();
        }
    }
}
