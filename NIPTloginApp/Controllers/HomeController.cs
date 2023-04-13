using Microsoft.AspNetCore.Mvc;
using NIPTloginApp.Models;
using System.Diagnostics;

namespace niptloginapp.controllers
{
    public class homecontroller : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public homecontroller(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public iactionresult error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
