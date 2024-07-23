using Microsoft.AspNetCore.Mvc;

namespace RunGroopWebApp.Controllers
{
    public class RaceController : Controller
    {
        // GET: RaceController
        public IActionResult Index()
        {
            return View();
        }

    }
}
