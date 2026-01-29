using Microsoft.AspNetCore.Mvc;

namespace TP1_Resto.Controllers
{
    public class PlatsDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Plats/details/{id}")]
        public IActionResult Details(int id)
        {
            return View(id);
        }

        //Vérifier que ça marche
		public IActionResult DetailsQuery(int id)
		{
			return View(id);
		}
	}
}
