using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2UrDoorBakery.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2UrDoorBakery.Controllers
{
    public class BakeryController : Controller
    {
        private readonly IBakeryRepository _bakeryRepository;

        public BakeryController(IBakeryRepository bakeryRepository)
        {
            _bakeryRepository = bakeryRepository;
        }

        public ViewResult List()
        {

            IEnumerable<Bakery> bakery;
            BakeryListViewModel bakeryListViewModel = new BakeryListViewModel();
            bakeryListViewModel.Bakery = _bakeryRepository.AllBakery;
            bakery = _bakeryRepository.AllBakery.OrderBy(p => p.BakeryId);


            return View(new BakeryListViewModel
            {
                Bakery=bakery
            });
        }
        public IActionResult Details(int id)
        {
            var item= _bakeryRepository.GetBakeryById(id);
            if ( item== null)
                return NotFound();

            return View(item);
        }
    }
}