using MoviesApp.Models;
using System;
using System.Collections.Generic;

namespace MoviesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press a Key to Exit program");
            List<string> Movies = new List<string>();
            foreach (var movie in Movie.GetMovies())
            {
                Movies.Add(BuildMovieString(movie));
            }
            PrintMovies(Movies);
            Console.ReadKey();
        }
        static void PrintMovies(List<string>Movies)
        {
            foreach(var Movie in Movies)
            {
                Console.WriteLine(Movie);
            }
        }
        static string BuildMovieString(Movie movie)
        {
            string title = movie?.title ?? "<NoTitle>";
            string director = movie?.director ?? "<NoDirector>";
            int? movieCode = movie?.movieCode ?? 0;
            string sequelTitle = movie?.sequel?.title ?? "<noSequel>";
            return $"movieCode:{movieCode}\nTitle:{title}\nDirector:{director}\nSequel:{sequelTitle}\n";
        }
    }
}
