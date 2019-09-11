using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewViewModelExample.Models
{
    public class Games
    {
        public List<Game> MyGames { get; set; }
        public Games()
        {
            MyGames = new List<Game> {
                new Game { GameId = 1, GameTitle = "Wolfenstein", GamePublisher = "EA" },
                new Game { GameId = 2, GameTitle = "FIFA 2020", GamePublisher = "EA" },
                new Game { GameId = 3, GameTitle = "Mortal Combat", GamePublisher = "Ubisoft" },
                new Game { GameId = 4, GameTitle = "Doom", GamePublisher = "Sega" },
                };
        }

       
    }
}
