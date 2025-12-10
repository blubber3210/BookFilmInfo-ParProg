namespace BookFilmInfo_ParProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kommentar

            List<Bok> books = new List<Bok>();
            List<Film> movies = new List<Film>();

            //Console.WriteLine("Hello friend, do you want to add a book or a movie?");
            //Console.WriteLine("1. Book");
            //Console.WriteLine("1. Movie");


            //int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Title:");
            string inputTitle = Console.ReadLine();
            Console.WriteLine("Year it came out:");
            int inputYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Description:");
            string inputDescription = Console.ReadLine();
            Console.WriteLine("Director:");
            string inputDirector = Console.ReadLine();

            //Console.WriteLine("Title: " + inputTitle);
            //Console.WriteLine("Year: " + inputYear);
            //Console.WriteLine("Description: " + inputDescription);
            //Console.WriteLine("Director: " + inputDirector);

            Film inputFilm = new Film(inputTitle, inputYear, inputDescription, inputDirector);

            Film.PrintMovieInfo(inputFilm);

        }
    }
}
