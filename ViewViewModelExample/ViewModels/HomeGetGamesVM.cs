using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.Games.Domain;
namespace ViewViewModelExample.ViewModels
{
    public class HomeGetGamesVM
    {
        public IEnumerable<Game> games = new List<Game>();
    }
}
