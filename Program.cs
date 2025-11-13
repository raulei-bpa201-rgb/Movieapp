using MovieApp.Models;
using MovieApp.Services;
using MovieApp.Interfaces;

namespace MovieApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var movies = new List<Movie>
            //{
            //    new Movie("Inception", 2010,false, Genre.SciFi),
            //    new Movie("The Dark Knight", 2008, true, Genre.Action),
            //    new Movie("Titanic", 1997, false, Genre.Romance),
            //    new Movie("The Godfather", 1972, true, Genre.Drama),
            //    new Movie("The Conjuring", 2013, false, Genre.Horror),
            //    new Movie("Interstellar", 2014, true, Genre.SciFi),
            //    new Movie("Joker", 2019, true, Genre.Drama),
            //    new Movie("Superbad", 2007, false, Genre.Comedy),
            //    new Movie("Free Solo", 2018, true, Genre.Documentary),
            //    new Movie("Avengers: Endgame", 2019, true, Genre.Action)
            //};

            //foreach (var movie in movies)
            //{
            //    movie.Start();
            //    movie.MarkAsWatched();
            //    movie.DisplayInfo();
            //    Console.WriteLine("**********************");
            //}

            MovieManager manager = new MovieManager();

            // 1️⃣ Create test movies
            var movies = new List<Movie>
            {
                new Movie("Inception", 2010, false, Genre.SciFi),
                new Movie("The Dark Knight", 2008, true, Genre.Action),
                new Movie("Titanic", 1997, false, Genre.Romance)
            };

            // 2️⃣ Save movies to JSON
            manager.Add(movies);
            Console.WriteLine("Movies saved to JSON!");

            // 3️⃣ Read and display movies
            Console.WriteLine("\nMovies loaded from JSON:");
            manager.Show();
        }
    }
}
