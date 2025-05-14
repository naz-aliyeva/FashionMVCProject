using FashionMVCProject.Contexts;
using FashionMVCProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FashionMVCProject.Areas.Admin.Controllers;
[Area("Admin")]
public class DashboardController : Controller

{
    private readonly FeaturedProductService _context;
    public DashboardController()
    {
        _context = new FeaturedProductService();

    }
    public IActionResult Index()
    {
        List<FeaturedProducts> featuredProducts = _context.FeaturedProducts.ToList();
        return View(featuredProducts);
    }
}
