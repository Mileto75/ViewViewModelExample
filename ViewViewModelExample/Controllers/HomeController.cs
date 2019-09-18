using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewViewModelExample.Models;
using ViewViewModelExample.ViewModels;

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
            ViewBag.PageTitle = "My Game";
            //create the ViewModel
            var gameVm = new HomeGetGameVM();
            //populate the ViewModel
            gameVm.GameId = 1;
            gameVm.GameTitle = "Wolfenstein Colossus";
            gameVm.GamePublisher = "Machine Games";
            //pass the ViewModel to the View
            return View(gameVm);
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
