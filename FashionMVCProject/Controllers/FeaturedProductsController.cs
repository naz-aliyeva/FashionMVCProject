using FashionMVCProject.Contexts;
using FashionMVCProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FashionMVCProject.Controllers
{
    [Area("Admin")]
    public class FeaturedProductsController : Controller
    {

        private readonly AppDbContext _context;

        public FeaturedProductsController()
        {
            _context = new AppDbContext();
        }

        [HttpGet]
        public IActionResult Index()
        {

            List<FeaturedProducts> flowerSliders = _context.FeaturedProducts.ToList();
            return View(flowerSliders);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Create(FeaturedProducts products)
        {
            return View();
        }

    }
}
