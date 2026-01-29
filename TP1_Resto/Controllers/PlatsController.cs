using Microsoft.AspNetCore.Mvc;

namespace TP1_Resto.Controllers
{
    public class PlatsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Views/Plats/{categories?}")]
        public IActionResult Categories(string categories)
        {
            return View(categories);
        }
    }
}
