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
        //public string[] Actors;

        public Film(string title, int year, string description, string director)
        {
            Title = title;
            Year = year;
            Description = description;
            Director = director;
            //Actors = actors;
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
        }


    }
}
