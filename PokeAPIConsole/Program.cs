using PokeAPICore;
using System;
using System.Threading.Tasks;

namespace PokeAPIConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            PokeApiClient client = new PokeApiClient();
            Pokemon result = await client.GetPokemonByName("bulbasaur");

            Console.WriteLine($" PokemonID: {result.id} " +
                              $"\n Name: {result.name} " +
                              $"\n Weight (hectograms): {result.weight} " +
                              $"\n Height (inches): {result.height} ");

            Console.ReadKey();
        }
    }
}
