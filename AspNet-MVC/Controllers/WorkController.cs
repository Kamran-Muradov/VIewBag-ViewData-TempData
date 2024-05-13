using Microsoft.AspNetCore.Mvc;

namespace AspNet_MVC.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
