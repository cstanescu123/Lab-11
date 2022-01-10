using System;
using System.Collections.Generic;
using System.Linq;

namespace movie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("The Simpsons Movie", "Animated"));
            movies.Add(new Movie("Aladdin", "Animated"));
            movies.Add(new Movie("Saw", "Horror"));
            movies.Add(new Movie("Saw 2", "Horror"));
            movies.Add(new Movie("Gangs of New York", "Drama"));
            movies.Add(new Movie("The Prestige", "Drama"));
            movies.Add(new Movie("Star Wars", "Scifi"));
            movies.Add(new Movie("Star Trek", "Scifi"));

            foreach (var movie in movies)

                Console.WriteLine("What category are you interested in?");
            string userInput = Console.ReadLine();



            Console.WriteLine("Continue? (y/n)");
            string userInput1 = Console.ReadLine();



        }
    }
}
