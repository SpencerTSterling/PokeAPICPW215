using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PokeAPICore;
using PokeAPIWebsite.Models;

namespace PokeAPIWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            int desiredId = 1;

            Pokemon result = await PokeAPIHelper.GetById(desiredId);

            var entry = new PokedexEntryViewModel()
            {
                Id = result.id,
                Name = result.Name,
                Height = result.Height.ToString(),
                Weight = result.Weight.ToString(),
                PokedexImageUrl = result.sprites.FrontDefault,
                MoveList = result.moves.OrderBy(m => m.move.name).Select(m => m.move.name).ToArray()
            };
            entry.Name = entry.Name[0].ToString().ToUpper() + 
                         entry.Name.Substring(1);
                        

            return View(entry);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
