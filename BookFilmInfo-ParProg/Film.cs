using System;
using System.Collections.Generic;
using System.Text;

namespace BookFilmInfo_ParProg
{
    internal class Film
    {
        public string Title;
        public int Year;
        public string Description;
        public string Director;
        public string Actors;

        public Film(string title, int year, string description, string director, string actors)
        {
            Title = title;
            Year = year;
            Description = description;
            Director = director;
            Actors = actors;
        }

        public static void PrintMovieInfo(Film film)
        {
            Console.WriteLine();
            Console.WriteLine("Info about the movie:");
            Console.WriteLine();
            Console.WriteLine("Title: " + film.Title);
            Console.WriteLine("Year: " + film.Year);
            Console.WriteLine("Description: " + film.Description);
            Console.WriteLine("Director: " + film.Director);
            Console.WriteLine("Actors: " + film.Actors);
        }

        public static Film RunMovieInput()
        {
            Console.WriteLine("Title:");
            string inputTitle = Console.ReadLine();
            Console.WriteLine("Year it came out:");
            int inputYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Description:");
            string inputDescription = Console.ReadLine();
            Console.WriteLine("Director:");
            string inputDirector = Console.ReadLine();
            Console.WriteLine("Actors: ");
            string inputActors = Console.ReadLine();

            Film inputFilm = new Film(inputTitle, inputYear, inputDescription, inputDirector, inputActors);

            PrintMovieInfo(inputFilm);
            return inputFilm;
        }

        public static void PrintAllMovies(List<Film> allfilms)
        {
            
            foreach (Film movie in allfilms)
            {
                PrintMovieInfo(movie);
            }
        }

    }
}
