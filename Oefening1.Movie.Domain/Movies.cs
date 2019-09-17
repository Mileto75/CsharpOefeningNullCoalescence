using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1.Movie.Domain
{
    public class Movie
    {
        public int? movieCode { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public string director { get; set; }
        public Movie sequel { get; set; }

        public static List<Movie> GetMovies()
        {
            List<Movie> Movies = new List<Movie>();
            Movies.Add(new Movie
                    {
                        movieCode = null,
                        title = "Indiana Jones 1",
                        director = null,
                        sequel = new Movie
                                {
                                    movieCode=12,
                                    title = "Indiana Jones 2",
                                    genre = "Adventure",
                                    director = null
                                },
                        genre = "Adventure"
                    }
            );
            Movies.Add(null);
            Movies.Add(new Movie
            {
                movieCode = 13,
                title = "Avengers 1",
                director = null,
                sequel = null,
                genre = "Adventure"
            });
            return Movies;

        }
        
    }
}
