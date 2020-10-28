using PokeAPICore;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PokeAPIConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            PokeApiClient client = new PokeApiClient();

            try
            {

                Pokemon result = await client.GetPokemonByName("Bulbasaur");

                Console.WriteLine($" PokemonID: {result.id} " +
                                  $"\n Name: {result.Name} " +
                                  $"\n Weight (hectograms): {result.Weight} " +
                                  $"\n Height (inches): {result.Height} ");
            }
            catch(ArgumentException)
            {
                Console.WriteLine("That Pokemon does not exist");
            }
            catch (HttpRequestException)
            {
                Console.WriteLine("Please try again later");
            }


            Console.ReadKey();
        }
    }
}
