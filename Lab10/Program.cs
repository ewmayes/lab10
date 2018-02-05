using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> MovieList = new List<Movie>();

            MovieList.Add(new Movie("Star Wars", "scifi"));
            MovieList.Add(new Movie("2001: A Space Odyssey", "scifi"));
            MovieList.Add(new Movie("E.T. the Extra-Terrestrial", "scifi"));
            MovieList.Add(new Movie("A Clockwork Orange", "scifi"));
            MovieList.Add(new Movie("Close Encounters of the Third Kind", "scifi"));
            MovieList.Add(new Movie("Spirited Away", "animated"));
            MovieList.Add(new Movie("Pinocchio", "animated"));
            MovieList.Add(new Movie("There Will Be Blood", "drama"));
            MovieList.Add(new Movie("Million Dollar Baby", "drama"));
            MovieList.Add(new Movie("It", "horror"));

            Console.WriteLine("Welcome to the Movie List Application!\n");
            Console.WriteLine("There are 100 movies in the list.");

            var UserInput = "a";

            do
            {
                Console.WriteLine("What category are you interested in?");
                string Answer = Console.ReadLine();
                Console.WriteLine();

                if (Regex.Match(Answer, "^s", RegexOptions.IgnoreCase).Success)
                    PickScifi(MovieList, Answer);
                else if (Regex.Match(Answer, "^a", RegexOptions.IgnoreCase).Success)
                    PickAnimated(MovieList, Answer);
                else if (Regex.Match(Answer, "^d", RegexOptions.IgnoreCase).Success)
                    PickDrama(MovieList, Answer);
                else if (Regex.Match(Answer, "^h", RegexOptions.IgnoreCase).Success)
                    PickHorror(MovieList, Answer);
                else
                    Console.WriteLine("Please enter a valid input!");

                Console.WriteLine("\nContinue? (y/n)");
                UserInput = Console.ReadLine();

                while (!Regex.Match(UserInput, @"^(yes|y|no|n)$").Success)

                {
                    Console.WriteLine("Please enter a valid input to begin again!");
                    UserInput = Console.ReadLine();
                }
            }
            while
                ((UserInput == "y") || (UserInput =="yes"));
                
        }

        static public void PickScifi(List<Movie> MovieList, string Answer)
        {
            foreach (Movie m in MovieList)
            {
                if (m.Category == "scifi")
                    Console.WriteLine(m.Title);
            }
            
        }
        static public void PickAnimated(List<Movie> MovieList, string Answer)
        {
            foreach (Movie m in MovieList)
            {
                if (m.Category == "animated")
                    Console.WriteLine(m.Title);
            }
        }
        static public void PickDrama(List<Movie> MovieList, string Answer)
        {
            foreach (Movie m in MovieList)
            {
                if (m.Category == "drama")
                    Console.WriteLine(m.Title);
            }
        }
        static public void PickHorror(List<Movie> MovieList, string Answer)
        {
            foreach (Movie m in MovieList)
            {
                if (m.Category == "horror")
                    Console.WriteLine(m.Title);
            }
        }
    }
}
