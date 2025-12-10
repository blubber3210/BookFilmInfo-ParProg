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
    }
}
