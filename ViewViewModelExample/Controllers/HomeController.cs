using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Example.Games.Domain;
using ViewViewModelExample.ViewModels;
using ViewViewModelExample.Models;

namespace ViewViewModelExample.Controllers
{
    public class HomeController : Controller
    {
        private Gamerepository gameRepository;
        public HomeController()
        {
            gameRepository = new Gamerepository();
        }
        public IActionResult Index()
        {
            return View();
        }


        [Route("games/getgames")]
        public IActionResult GetGames()
        {
            ViewBag.PageTitle = "My Games";
            //create the ViewModel
            var gamesVM = new HomeGetGamesVM();
            //populate the ViewModel
            gamesVM.games = gameRepository.GetGames();
            //pass the ViewModel to the View
            return View(gamesVM);
        }
        [Route("games/getgame/{GameId}")]
        public IActionResult GetGame(int GameId)
        {
            //make the model
            HomeGetGameVM myGameVM = new HomeGetGameVM();
            //get the game
            Game myGame = gameRepository.GetGames().FirstOrDefault(g => g.GameId == GameId);
            //put in ViewModel
            myGameVM.GameId = myGame?.GameId ?? -1;
            myGameVM.GameTitle = myGame?.GameTitle ?? "<NoTitle>";
            myGameVM.GamePublisher = myGame?.GamePublisher ?? "<NoPublisher>";
            return View(myGameVM);
        }
        [Route("home/rategame/{GameId}/{Rating}")]
        public IActionResult RateGame(int gameId, int? rating)
        {
            //Viewmodel declareren
            HomeRateGameVM homeRateGameVM = new HomeRateGameVM();
            var game = gameRepository.GetGames().FirstOrDefault(g => g.GameId == gameId);
            homeRateGameVM.GameId = game?.GameId ?? 0;
            homeRateGameVM.Gametitle = game?.GameTitle ?? "<NoTitle>";
            homeRateGameVM.Gamerating = rating ?? 0;
            return View(homeRateGameVM);
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
