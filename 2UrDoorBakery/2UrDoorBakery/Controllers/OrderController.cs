using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2UrDoorBakery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace _2UrDoorBakery.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public IActionResult OrderForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderForm(Order order)
        {
            if(ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                return RedirectToAction("OrderCompleted");
            }
            return View(order);
        }

        public IActionResult OrderCompleted()
        {
            ViewBag.OrderCompletedMessage = "Thank you for you order. See you soon!";

            return View();
        }
    }
}