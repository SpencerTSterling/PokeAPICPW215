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
            string result = await client.GetPokemonByName("pikachu");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
