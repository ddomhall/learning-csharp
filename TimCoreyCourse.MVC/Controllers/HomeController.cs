using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TimCoreyCourse.MVC.Models;

namespace TimCoreyCourse.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Address()
        {

            return View(new Address());
        }

        [HttpPost]
        public IActionResult Address(Address address)
        {
            return View(address);
        }

        public IActionResult Person()
        {

            return View(new Person());
        }

        [HttpPost]
        public IActionResult Person(Person person)
        {
            return View(person);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
