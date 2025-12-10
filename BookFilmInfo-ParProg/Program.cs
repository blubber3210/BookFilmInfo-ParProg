using System;

namespace BookFilmInfo_ParProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kommentar

            List<Bok> books = new List<Bok>();
            List<Film> movies = new List<Film>();

            


            while (true)
            {
                
                var input = Input();

                if (input == 1)
                {
                    Bok inputBok = Bok.RunBookInput();
                    books.Add(inputBok);
                }

                if (input == 2)
                {
                    Film inputFilm = Film.RunMovieInput();
                    movies.Add(inputFilm);
                }

                if (input == 3)
                {
                    PrintLine();
                    Console.WriteLine("All books added : ");
                    PrintLine();
                    Bok.PrintAllBooks(books);
                }

                if (input == 4)
                {
                    PrintLine();
                    Console.WriteLine("All movies added : ");
                    PrintLine();
                    Film.PrintAllMovies(movies);
                }

                if (input == 5)
                {
                    PrintLine();
                    Console.WriteLine("All movies added : ");
                    PrintLine();
                    Film.PrintAllMovies(movies);
                    PrintLine();
                    Console.WriteLine("All books added : ");
                    PrintLine();
                    Bok.PrintAllBooks(books);
                }

                else
                {
                    PrintLine();
                    Console.WriteLine("that's all");
                    PrintLine();
                }
                
            }

        }

        private static int Input()
        {
            PrintLine();
            Console.WriteLine("Hello friend, do you want to add a book or a movie, or see all the things you've just added in list?");
            Console.WriteLine("1. Book");
            Console.WriteLine("2. Movie");
            Console.WriteLine("3. View all books");
            Console.WriteLine("4. View all movies");
            Console.WriteLine("5. View all books AND movies");
            PrintLine();

            int input = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return input;
            
        }

        private static void PrintLine()
        {
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
