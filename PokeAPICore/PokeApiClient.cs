﻿using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PokeAPICore
{
    /// <summary>
    /// Client class to consume PokeApi
    /// https://pokeapi.co/
    /// </summary>
    public class PokeApiClient
    {
        static readonly HttpClient client = new HttpClient();

        /// <summary>
        /// retrieve pokemon by name
        /// </summary>
        /// <exception cref="HttpRequestException"></exception>
        /// <param name="name"></param>
        /// <exception cref="ArgumentException">Thrown when Pokemon is not found</exception>
        /// <returns></returns>
        public async Task<Pokemon> GetPokemonByName(string name)
        {
            name = name.ToLower(); // Pokemon name MUST be lowercase

            string url = $"https://pokeapi.co/api/v2/pokemon/{name}";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Pokemon>(responseBody);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new ArgumentException($"{name} does not exist.");
            }
            else
            {
                throw new HttpRequestException();
            }
        }

        public void GetPokemonById(int id)
        {
            throw new NotImplementedException();
        }


    }
}
