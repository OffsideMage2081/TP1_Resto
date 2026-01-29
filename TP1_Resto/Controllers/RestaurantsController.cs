using Microsoft.AspNetCore.Mvc;

namespace TP1_Resto.Controllers
{
    public class RestaurantsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
