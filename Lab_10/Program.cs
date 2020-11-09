using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userContinue;
            do
            {
                bool invalidInput;
                do
                {

                    List<Movie> movieGenreList = BuildMovieList();

                    Console.WriteLine("Welcome To The Movie List Application!\n There are 10 Movies in the list.\n What category are you intetested in? (Horror, Drama, Scifi, or Animated)");
                    var userCategory = Console.ReadLine();
                    invalidInput = IsInputAccepted(userCategory);

                    GetMovies(userCategory, movieGenreList);                    
                } while (invalidInput);
                userContinue = CloseApplication();
            } while (userContinue);
            
           

        }

        private static bool CloseApplication()
        {
            var keepLooping = true;
            while (keepLooping) 
            {
                Console.WriteLine("Continue? (y/n)");
                var userInput = Console.ReadLine();
                if (userInput.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if (userInput.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Thank you");
                    return false;
                }
                else
                {
                    Console.WriteLine("That is not a valid selection");
                    continue;

                }
            }
            return false;

        }

        public static bool IsInputAccepted(string userInput)
        {
            if((userInput.Equals("horror", StringComparison.OrdinalIgnoreCase)) || (userInput.Equals("scifi", StringComparison.OrdinalIgnoreCase)) || (userInput.Equals("Animated", StringComparison.OrdinalIgnoreCase)) || (userInput.Equals("Drama", StringComparison.OrdinalIgnoreCase))) 
            {
                return false;
            }
            else
            {
                Console.WriteLine("This is not a valid selection, please try again");
                return true;
            }
        }

        public static void GetMovies(string userGenreSelected, List<Movie> movieGenreList)
        {
            
            foreach (Movie movie in movieGenreList)
            {
                if (userGenreSelected.Equals("Horror", StringComparison.OrdinalIgnoreCase))
                {
                    if (movie.GetGenre().Equals(userGenreSelected, StringComparison.OrdinalIgnoreCase))
                       Console.WriteLine(movie.GetTitle());
                        
                    
                    
                }
                else if (userGenreSelected.Equals("Scifi", StringComparison.OrdinalIgnoreCase))
                {
                    if (movie.GetGenre().Equals(userGenreSelected, StringComparison.OrdinalIgnoreCase))
                        Console.WriteLine(movie.GetTitle());
                        
                    
                   
                }
                else if (userGenreSelected.Equals("Drama", StringComparison.OrdinalIgnoreCase))
                {
                    if (movie.GetGenre().Equals(userGenreSelected, StringComparison.OrdinalIgnoreCase))
                        Console.WriteLine(movie.GetTitle());
                        
                    
                    
                }
                else if (userGenreSelected.Equals("Animated", StringComparison.OrdinalIgnoreCase))
                {
                    if (movie.GetGenre().Equals(userGenreSelected, StringComparison.OrdinalIgnoreCase))
                       Console.WriteLine(movie.GetTitle());                      
                    
                    
                }
                
            }
           
        }

        private static List<Movie> BuildMovieList()
        {
            List<Movie> movieGenre = new List<Movie>();


            movieGenre.Add(new Movie("Drama", "The Godfather"));
            movieGenre.Add(new Movie("Drama", "The Shawshank Redemption"));
            movieGenre.Add(new Movie("Scifi", "Star Wars"));
            movieGenre.Add(new Movie("SciFi", "E.T. The Extra-Terrestrial"));
            movieGenre.Add(new Movie("Horror", "Friday the 13th"));
            movieGenre.Add(new Movie("Horror", "A Nightmare on Elm Street"));
            movieGenre.Add(new Movie("Animated", "Toy Story"));
            movieGenre.Add(new Movie("Animated", "The Lion King"));
            movieGenre.Add(new Movie("Horror", "Poltergeist"));
            movieGenre.Add(new Movie("Drama", "Schindler's List"));

            return movieGenre;
        }

    }

    public class Movie
    {       

        public Movie(string movieGenre, string movieTitle)
        {
            _movieGenre = movieGenre;
            _movieTitle = movieTitle;
        }





        private string _movieTitle;
        public string GetTitle()
        {
            return _movieTitle;
        }
        private string _movieGenre;
        public string GetGenre()
        {
            return _movieGenre;
        }















    }
}
