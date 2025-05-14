using FashionMVCProject.Contexts;
using FashionMVCProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FashionMVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FeaturedProductsController : Controller
    {
        private readonly FeaturedProductService _service;
        public FeaturedProductsController() { 
        _service =new FeaturedProductService ();    
        }
        public IActionResult Index => View();

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(FeaturedProducts featured)
        {
            _service.CreateFeaturedProducts(featured);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        #endregion
        #region Read

        [HttpGet]
        public IActionResult Index()
        {
            List<FeaturedProducts> featuredProducts = _service.GetAllFeaturedProducts();
            return View(featuredProducts);
        }
        public IActionResult Info(int id)
        {
            FeaturedProducts featuredProducts = _service.GetFeaturedProductsById(id);
            return View(featuredProducts);
        }
        #endregion

        #region Update
        [HttpGet]
        public IActionResult Update(int id)
        {
            FeaturedProducts products = _service.GetFeaturedProductsById(id);
            return View(products);
        }
        [HttpPost]
        public IActionResult Update(int id, FeaturedProducts featured)
        {

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            FeaturedProducts featured = _service.GetFeaturedProductsById(id);
            return View(featured);
            //_service.DeleteFeaturedCar(id); 
            //return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {

            _service.DeleteFeaturedProducts(id);
            return RedirectToAction(nameof(Index));
        }

        #endregion
    }
}
