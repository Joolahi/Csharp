using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace T25_Movie_Stars
{
    class Human
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }
    }

    class Actor : Human
    {
    }

    class Director : Human
    {
    }

    class Movie
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public Director Director { get; }
        public List<Actor> Actors { get; }

        public Movie(string name, int year, Director director, List<Actor> actors)
        {
            Name = name;
            Year = year;
            Director = director;
            Actors = actors;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating 2 directors
            var director1 = new Director
            {
                Name = "Gore Verbinski",
                BirthYear = 1964
            };
            var director2 = new Director
            {
                Name = "John Guilbert Avildsen",
                BirthYear = 1935
            };

            //Creating some actors for 2 movies
            var actor1 = new Actor { Name = "Johnny Depp", BirthYear = 1963 };
            var actor2 = new Actor { Name = "Geoffrey Rush", BirthYear = 1951 };
            var actor3 = new Actor { Name = "Sylvester Stallone", BirthYear = 1946 };
            var actor4 = new Actor { Name = "Talia Shire", BirthYear = 1946 };

            // Creating 1st movie
            var movie1 = new Movie(
                name: "Pirates of the Caribbean: The Curse of the Black Pearl",
                year: 2003,
                director: director1,
                actors: new List<Actor> { actor1, actor2 }

                );

            //Creating 2nd movie 
            var movie2 = new Movie(
              name: "Rocky ",
              year: 1976,
              director: director2,
              actors: new List<Actor> { actor3, actor4 }
              );

            //Printing infos of 1st movie
            Console.WriteLine($"Movie Name: {movie1.Name}");
            Console.WriteLine($"Year: {movie1.Year}");
            Console.WriteLine($"Director: {movie1.Director.Name} - {movie1.Director.BirthYear}");
            Console.WriteLine("Actors: ");
            foreach (var actor in movie1.Actors) 
            {
                Console.WriteLine($"--{actor.Name} - {actor.BirthYear}");
            }

            //Printing infos of 2nd movie
            Console.WriteLine($"Movie Name: {movie2.Name}");
            Console.WriteLine($"Year: {movie2.Year}");
            Console.WriteLine($"Director: {movie2.Director.Name} - {movie2.Director.BirthYear}");
            Console.WriteLine("Actors: ");
            foreach (var actor in movie2.Actors)
            {
                Console.WriteLine($"--{actor.Name} - {actor.BirthYear}");
            }
        }
    }
}
