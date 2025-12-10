using System;
using System.Collections.Generic;
using System.Text;
using static System.Reflection.Metadata.BlobBuilder;

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
            Console.WriteLine();
            Console.WriteLine("Info about the book:");
            Console.WriteLine();
            Console.WriteLine("Title: " + bok.Title);
            Console.WriteLine("Year: " + bok.PublishedYear);
            Console.WriteLine("Description: " + bok.Description);
            Console.WriteLine("Director: " + bok.Author);
        }

        public static Bok RunBookInput()
        {
            Console.WriteLine("Title");
            string inputBookTitle = Console.ReadLine();
            Console.WriteLine("Published");
            int inputBookYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Description");
            string inputBookDescription = Console.ReadLine();
            Console.WriteLine("Author");
            string inputBookAuthor = Console.ReadLine();

            Bok inputBok = new Bok(inputBookTitle, inputBookYear, inputBookDescription, inputBookAuthor);

            

            PrintBookInfo(inputBok);
            return inputBok;
        }

        public static void PrintAllBooks(List<Bok> allbooks)
        {
            
            foreach (Bok book in allbooks)
            {
                PrintBookInfo(book);
            }
        }
    }
}
