using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewViewModelExample.Models;

namespace ViewViewModelExample.Controllers
{
    public class HomeController : Controller
    {
        private Games myGames;
        public HomeController()
        {
            myGames = new Games();
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("games/getgames")]
        public IActionResult GetGames()
        {
            ViewBag.Title= "My Games";
            ViewBag.MyGames = myGames.MyGames;
            return View();
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
