
using AspNet_MVC.Data;
using AspNet_MVC.Models;
using AspNet_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNet_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
           
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            ViewBag.sliderImage = _context.SliderImages.FirstOrDefaultAsync().Result.Name;

            return View(sliders);
        }

    }
}
