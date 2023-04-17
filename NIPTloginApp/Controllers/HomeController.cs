using Microsoft.AspNetCore.Mvc;
using NIPTloginApp.Models;
using System.Diagnostics;

// Reviewer Prowess: wrong namespace standard
namespace niptloginapp.controllers
{
// Reviewer Prowess: change class to correct naming convention as homeController
    public class homecontroller : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public homecontroller(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
// Reviewer Prowess: change interface name 
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        
        // Reviewer Prowess: wrong method name here
        public iactionresult error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
