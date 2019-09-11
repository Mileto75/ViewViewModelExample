using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewViewModelExample.Models
{
    public class Games
    {
        public List<HomeGetGameVM> MyGames { get; set; }
        public Games()
        {
            MyGames = new List<HomeGetGameVM> {
                new HomeGetGameVM { GameId = 1, GameTitle = "Wolfenstein", GamePublisher = "EA" },
                new HomeGetGameVM { GameId = 2, GameTitle = "FIFA 2020", GamePublisher = "EA" },
                new HomeGetGameVM { GameId = 3, GameTitle = "Mortal Combat", GamePublisher = "Ubisoft" },
                new HomeGetGameVM { GameId = 4, GameTitle = "Doom", GamePublisher = "Sega" },
                };
        }

       
    }
}
