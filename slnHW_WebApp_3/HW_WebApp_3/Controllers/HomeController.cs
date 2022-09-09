using HW_WebApp_3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HW_WebApp_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static readonly FishViewModel[] fish = new[]
        {
            new FishViewModel
            {
                Name = "Судак",
                Weight = 3,
                Speed = 12
            },
            new FishViewModel
            {
                Name = "Карась",
                Weight = 1,
                Speed = 10
            },
            new FishViewModel
            {
                Name = "Сазан",
                Weight = 5,
                Speed = 8
            }
        };


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult FishByViewData()
        {
            ViewData["Fish"] = fish;
            return View();
        }

        public IActionResult FishByViewBag()
        {
            ViewBag.Fish = fish;
            return View();
        }

        public IActionResult FishByModel()
        {
            FishViewModel myFish = new FishViewModel
            {
                Name = "Карп",
                Weight = 5,
                Speed = 8
            };

            ViewData["myFish"] = myFish;
            return View(fish);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}