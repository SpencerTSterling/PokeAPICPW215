using PokeAPICore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeAPIWebsite.Models
{
    public class PokeAPIHelper
    {
        /// <summary>
        /// Get pokemon by id
        /// Moves will be sorted in alphabetical order
        /// </summary>
        /// <param name="desiredId"></param>
        /// <returns></returns>
        public static async Task<Pokemon> GetById(int desiredId)
        {

            PokeApiClient myClient = new PokeApiClient();
            Pokemon result = await myClient.GetPokemonById(desiredId);

            result.moves.OrderBy(m => m.move.name);

            return result;
        }

        public static PokedexEntryViewModel GetPokedexEntryFromPokemon(Pokemon result)
        {
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
            return entry;
        }
    }
}
