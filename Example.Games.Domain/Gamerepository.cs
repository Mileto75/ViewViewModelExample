using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Games.Domain
{
    class Gamerepository
    {
        private IEnumerable<Game> MyGames;
        public IEnumerable<Game> GetGames()
        {
            MyGames = new List<Game>
            {
                new Game{GameId=0,GameTitle="Wolfenstein",GamePublisher="Ubisoft" },
                new Game{GameId=1,GameTitle="Fifa",GamePublisher="EA" },
                new Game{GameId=2,GameTitle="Doom",GamePublisher="Bethesta" },
                new Game{GameId=3,GameTitle="Call of duty",GamePublisher="Ubisoft" }
            };
            return MyGames;
        }

    }
}
