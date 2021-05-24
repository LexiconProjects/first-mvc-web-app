using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyMVCWebApp.Models;
using Microsoft.AspNetCore.Http;

namespace MyMVCWebApp.Controllers
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

        public IActionResult Projects()
        {
            return View();
        }

        public RedirectToActionResult RedirectDemo()
        {
            return RedirectToAction("Demo", "Home");
        }

        public IActionResult Demo()
        {
            return View();
        }
        public IActionResult DemoGame()
        {
            HttpContext.Session.SetInt32("randomGuess",DemoGameModel.GetRandomNumber());
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CheckTemperature(float temperature, string scale)
        {
            ViewBag.TemperatureCheckResult = TemperatureCheckModel.CheckTemp(temperature, scale);
            return View("Demo");
            
        }

        [HttpPost]
        public ActionResult CheckGuess(int inputGuess)
        {
            int sessionNumber = (int) HttpContext.Session.GetInt32("randomGuess");
            ViewBag.NumberGuessResult = DemoGameModel.CheckUserGuess(inputGuess, sessionNumber);
            return View("DemoGame");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
