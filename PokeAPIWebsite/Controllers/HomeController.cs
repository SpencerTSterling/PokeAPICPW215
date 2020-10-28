﻿using System;
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
            PokeApiClient myClient = new PokeApiClient();
            Pokemon result = await myClient.GetPokemonById(1);

            var entry = new PokedexEntryViewModel()
            {
                Id = result.id,
                Name = result.name,
                Height = result.height.ToString(),
                Weight = result.weight.ToString(),
                PokedexImageUrl = result.sprites.front_default,
                // add movelist
                MoveList = new List<string>()
            };

            return View(entry);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
