using System;
using System.Collections.Generic;
using System.Text;

namespace BookFilmInfo_ParProg
{
    internal class Bok
    {
        public string Title;
        public int PublishedYear;
        public string Description;
        public string Author;

        public Bok(string title, int publishedYear, string description, string author)
        {
            Title = title;
            PublishedYear = publishedYear;
            Description = description;
            Author = author;
        }

        public static void PrintBookInfo(Bok bok)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Info about the book:");
            Console.WriteLine();
            Console.WriteLine("Title: " + bok.Title);
            Console.WriteLine("Year: " + bok.PublishedYear);
            Console.WriteLine("Description: " + bok.Description);
            Console.WriteLine("Director: " + bok.Author);
        }
    }
}
