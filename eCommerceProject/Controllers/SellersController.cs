using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using eCommerceProject.Models;
=======
>>>>>>> ef6a2e3c638722160e7e3472117c9c1cfad690db
using eCommerceProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
<<<<<<< HEAD

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

=======
>>>>>>> ef6a2e3c638722160e7e3472117c9c1cfad690db
    }
}
