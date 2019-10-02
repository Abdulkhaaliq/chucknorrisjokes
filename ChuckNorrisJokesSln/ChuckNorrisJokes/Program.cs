using ChuckNorrisJokesLibrary;
using System;
using System.Threading.Tasks;

namespace ChuckNorrisJokesConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            JokeGenerator jokeGenerator = new JokeGenerator();

            string randomJokeString = await jokeGenerator.GetRandomJoke();

            Console.WriteLine(randomJokeString);
            string[] catergories = await jokeGenerator.GetCategories();

            //  Console.WriteLine("Hello World!");
            for (int index = catergories.Length-1; index >=0; index--)
            {
                Console.WriteLine(catergories[index]);
            }
        }
    }
}
