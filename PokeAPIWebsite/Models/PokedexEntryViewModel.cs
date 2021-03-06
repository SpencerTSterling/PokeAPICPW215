﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeAPIWebsite.Models
{
    public class PokedexEntryViewModel
    {
        /// <summary>
        /// Infomation for a single Pokedex entry
        /// </summary>

        public string PokedexImageUrl { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public IEnumerable<string> MoveList { get; set; }
    }
}
