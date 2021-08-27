using System;
using System.Collections.Generic;
using System.Linq;

namespace MidTerm_MockBuster
{
    public class Movie
    {
        public string MovieName { get; set; }
        public string MainActor { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }

        public Movie(string _MovieName, string _MainActor, string _Genre, string _Director)
        {
            MovieName = _MovieName;
            MainActor = _MainActor;
            Genre = _Genre;
            Director = _Director;
        }

        public override string ToString()
        {
            return $"Title: {MovieName}, Actor: {MainActor}, Genre: {Genre}, Director: {Director}";
        }
    }

    public class MoviesRepo
    {
        public static List<Movie> GetMovie(List<Movie> TheList)
        {

            List<Movie> AllMovies = new List<Movie>();


            AllMovies = new List<Movie>
            {
                new Movie("The Rock", "Nicolas Cage", "Action", "Michael Bay"),
                new Movie("A Quiet Place", "Emily Blunt", "Horror", "Michael Bay"),
                new Movie("Songbird", "KJ Apa", "Thriller", "Michael Bay"),
                new Movie("Con Air", "Nicolas Cage", "Action", "Simon West"),
                new Movie("I Am Number Four", "Alex Pettyfer", "Sci-Fi", "Michael Bay"),
                new Movie("Seven Samari", "Toshiro Mifune", "Drama", "Akira Kurosawa"),
                new Movie("The Magnificent Seven", "Yul Brenner", "Western", "John Sturges"),
                new Movie("The Magnificent Seven", "Denzel Washington", "Western", "Antoine Fuqua"),
            };

            for (int index = 0; index < TheList.Count; index++)
            {
                Console.WriteLine($"{index + 1}. {TheList[index]}");
            }

            return AllMovies;
        }
    }

    class User
    {
        //Menu's that Allow for filtering

        //Method to filter by MovieName
        public static void FilterMovieName(List<Movie> TheList, string FilterName)
        {
            string FilterNameLower = FilterName;
            FilterNameLower = FilterName.ToLower();

            List<Movie> names = new List<Movie>(TheList);
            int count = 0;
            Movie found = null;
            foreach (Movie check in names)
            {
                string checkLower = check.MovieName;
                checkLower = checkLower.ToLower();
                count++;

                if (checkLower == FilterNameLower)
                {
                    found = check;
                    Console.WriteLine($"{count + 1}. Title: { found.MovieName}, Actor: { found.MainActor}, Genre: { found.Genre}, Director: { found.Director}");
                }
                else if (found == null && count == TheList.Count)
                {
                    Console.WriteLine($"{FilterName} wasn't found. Check the spelling and please try again or try another movie.");
                }
            }
        }

        //Method to filter by MainActor
        public static void FilterMainActor(List<Movie> TheList, string FilterName)
        {
            string FilterNameLower = FilterName;
            FilterNameLower = FilterName.ToLower();

            List<Movie> names = new List<Movie>(TheList);
            int count = 0;
            Movie found = null;
            foreach (Movie check in names)
            {
                string checkLower = check.MainActor;
                checkLower = checkLower.ToLower();
                count++;

                if (checkLower == FilterNameLower)
                {
                    found = check;
                    Console.WriteLine($"{count + 1}. Title: { found.MovieName}, Actor: { found.MainActor}, Genre: { found.Genre}, Director: { found.Director}");
                }
                else if (found == null && count == TheList.Count)
                {
                    Console.WriteLine($"{FilterName} wasn't found. Check the spelling and please try again or try another actor/actress.");
                }
            }

        }

        //Method to filter by Genre
        public static void FilterGenre(List<Movie> TheList, string FilterName)
        {
            string FilterNameLower = FilterName;
            FilterNameLower = FilterName.ToLower();

            List<Movie> names = new List<Movie>(TheList);
            int count = 0;
            Movie found = null;
            foreach (Movie check in names)
            {
                string checkLower = check.Genre;
                checkLower = checkLower.ToLower();
                count++;

                if (checkLower == FilterNameLower)
                {
                    found = check;
                    Console.WriteLine($"{count + 1}. Title: { found.MovieName}, Actor: { found.MainActor}, Genre: { found.Genre}, Director: { found.Director}");
                }
                else if (found == null && count == TheList.Count)
                {
                    Console.WriteLine($"{FilterName} wasn't found. Check the spelling and please try again or try another genre.");
                }
            }
        }

        //Method to filter by Director
        public static void FilterDirector(List<Movie> TheList, string FilterName)
        {
            string FilterNameLower = FilterName;
            FilterNameLower = FilterName.ToLower();

            List<Movie> names = new List<Movie>(TheList);
            int count = 0;
            Movie found = null;
            foreach (Movie check in names)
            {
                string checkLower = check.Director;
                checkLower = checkLower.ToLower();
                count++;

                if (checkLower == FilterNameLower)
                {
                    found = check;
                    Console.WriteLine($"{count + 1}. Title: { found.MovieName}, Actor: { found.MainActor}, Genre: { found.Genre}, Director: { found.Director}");
                }
                else if (found == null && count == TheList.Count)
                {
                    Console.WriteLine($"{FilterName} wasn't found. Check the spelling and please try again or try another director.");
                }
            }
        }
    }

    class Admin : User
    {
        //Menu's that Allow for filtering and CRUD functions
        //Admin+UserMenu

        //Method to filter by MovieName(Read/List)
        public static void FilterMovieAdmin(List<Movie> TheList, string FilterName)
        {
            User.FilterMovieName(TheList, FilterName);
        }
        //Method to filter by MainActor(Read)
        public static void FilterActorAdmin(List<Movie> TheList, string FilterName)
        {
            User.FilterMainActor(TheList, FilterName);
        }
        //Method to filter by Genre(Read/List)
        public static void FilterGenreAdmin(List<Movie> TheList, string FilterName)
        {
            User.FilterGenre(TheList, FilterName);
        }
        //Method to filter by Director(Read/List)
        public static void FilterDirectorAdmin(List<Movie> TheList, string FilterName)
        {
            User.FilterDirector(TheList, FilterName);
        }

        //AdminOnlyMenu

        //Method to filter by MovieName
        public static void CheckMovieName(List<Movie> TheList, string _MovieName)
        {
            bool tryAgain = true;
            
            while (tryAgain)
            {
                string FilterNameLower = _MovieName;
                FilterNameLower = _MovieName.ToLower();
            
                List<Movie> names = new List<Movie>(TheList);
                int count = 0;
                Movie found = null;
                foreach (Movie check in names)
                {
                    string checkLower = check.MovieName;
                    checkLower = checkLower.ToLower();
                    count++;

                    if (checkLower == FilterNameLower)
                    {
                        found = check;
                        Console.WriteLine("Sorry that movie already exists. Please try again or type CANCEL to return to the main menu.");
                        Console.Write("Title: ");
                        _MovieName = Console.ReadLine();

                    }
                    else if (found == null && count == TheList.Count)
                    {
                        tryAgain = false;
                    }
                }
                    
                
            }

        }

        //Method to AddMovie(Create)
        public static void AddMovie(List<Movie> AllMovies, string _MovieName, string _MainActor, string FilterName, string _Director)
        {
            string _Genre = "Action";
            switch (FilterName)
            {
                case "ACTION":
                    _Genre = "Action";
                    break;
                case "HORROR":
                    _Genre = "Horror";
                    break;
                case "THRILLER":
                    _Genre = "Thriller";
                    break;
                case "SCI-FI":
                    _Genre = "Sci-Fi";
                    break;
                case "DRAMA":
                    _Genre = "Drama";
                    break;
                case "COMEDY":
                    _Genre = "Comedy";
                    break;
                case "WAR":
                    _Genre = "War";
                    break;
                case "WESTERN":
                    _Genre = "Western";
                    break;
                case "SPORTS":
                    _Genre = "Sports";
                    break;
                case "ROMANCE":
                    _Genre = "Romance";
                    break;
                case "CRIME":
                    _Genre = "Crime";
                    break;
            }


            Movie mymovie = new Movie(_MovieName, _MainActor, _Genre, _Director);
            AllMovies.Add(mymovie);
            Console.WriteLine($"Added new movie {mymovie} to the repository.\n");
            Console.WriteLine("\nHere's the updated movie repository!\n");
            //AllMovies = MoviesRepo.GetMovie(AllMovies);
            MoviesRepo.GetMovie(AllMovies);
        }

        //Methods to Edit(Update) MovieName, MainActor, Genre, Director

        //Method to Edit MovieName

        public static void EditMovieName(List<Movie> AllMovies, int index, string MovieToUpd, string UpdMovie)
        {
            Movie mymovie = AllMovies[index - 1];
            MovieToUpd = mymovie.MovieName;

            Movie UpdMovieName = mymovie as Movie;
            //    Console.Write("Updated Director: ");
            UpdMovieName.MovieName = UpdMovie;
            Console.WriteLine($"\nThe Movie {MovieToUpd} was updated to {UpdMovieName.MovieName}.\n");
            Console.WriteLine("\nHere's the updated movie repository!\n");
            MoviesRepo.GetMovie(AllMovies);
        }

        //Method to Edit MainActor
        public static void EditMainActor(List<Movie> AllMovies, int index, string MainActorUpd)
        {
            Movie mymovie = AllMovies[index - 1];
            

            Movie UpdActor = mymovie as Movie;
            
            UpdActor.MainActor = MainActorUpd;
            Console.WriteLine($"\nThe Main Actor for {UpdActor.MovieName} was updated to {UpdActor.MainActor}.\n");
            Console.WriteLine("\nHere's the updated movie repository!\n");
            AllMovies = MoviesRepo.GetMovie(AllMovies);
        }

        //Method to Edit Genre
        public static void EditGenre(List<Movie> AllMovies, int index, string FilterName)
        {


            Movie mymovie = AllMovies[index - 1];

            string MovieToUpd = mymovie.MovieName;

            Movie UpdGenre = mymovie as Movie;

            UpdGenre.Genre = "Action";
            switch (FilterName)
            {
                case "ACTION":
                    UpdGenre.Genre = "Action";
                    break;
                case "HORROR":
                    UpdGenre.Genre = "Horror";
                    break;
                case "THRILLER":
                    UpdGenre.Genre = "Thriller";
                    break;
                case "SCI-FI":
                    UpdGenre.Genre = "Sci-Fi";
                    break;
                case "DRAMA":
                    UpdGenre.Genre = "Drama";
                    break;
                case "COMEDY":
                    UpdGenre.Genre = "Comedy";
                    break;
                case "WAR":
                    UpdGenre.Genre = "War";
                    break;
                case "WESTERN":
                    UpdGenre.Genre = "Western";
                    break;
                case "SPORTS":
                    UpdGenre.Genre = "Sports";
                    break;
                case "ROMANCE":
                    UpdGenre.Genre = "Romance";
                    break;
                case "CRIME":
                    UpdGenre.Genre = "Crime";
                    break;
            }
            Console.WriteLine($"The Genre for {UpdGenre.MovieName} was updated to {FilterName}.");
            Console.WriteLine("\nHere's the updated movie repository!\n");
            AllMovies = MoviesRepo.GetMovie(AllMovies);
        }

        //Method to Edit Director
        public static void EditDirector(List<Movie> AllMovies, int index, string DirectorUpd)
        {
            Movie mymovie = AllMovies[index - 1];
           

            Movie UpdDirector = mymovie as Movie;
           
            UpdDirector.Director = DirectorUpd;
            Console.WriteLine($"\nThe Director for {UpdDirector.MovieName} was updated to {UpdDirector.Director}.\n");
            Console.WriteLine("\nHere's the updated movie repository!\n");
            AllMovies = MoviesRepo.GetMovie(AllMovies);
        }

        //Method to DeleteMovie(Remove)
        public static void DeleteMovie(List<Movie> AllMovies, int index)
        {

            Console.WriteLine($"\nThe record for {AllMovies[index - 1]} has been deleted.");
            AllMovies.RemoveAt(index - 1);
            Console.WriteLine("\nHere's the updated movie repository!\n");
            AllMovies = MoviesRepo.GetMovie(AllMovies);
            //}
        }
    }

    class Program
    {
        static bool contBuster()
        {
            while (true)
            {
                Console.WriteLine("\n******************************************");
                Console.WriteLine("* Welcome Back to MockBuster's Main Menu *");
                Console.WriteLine("******************************************");
                Console.Write("\nDo you want to stay logged into MockBuster'S Movie Respository? (Enter 'yes' or 'no'): ");                        //Prompts for user input to continue or not
                string moreBuster = Console.ReadLine();
                moreBuster = moreBuster.ToLower();                           //Converts input case to only lower case

                if (moreBuster == "y" || moreBuster == "yes")                //Checks the condition to continue measuring rooms or quit
                {
                    return true;
                }
                else if (moreBuster == "n" || moreBuster == "no")
                {
                    return false;
                }
                else
                {
                    Console.Write("Please enter only y or n!");                //Prompts user to only enter a y (yes ) or n (no) if another character is entered
                }
            }
        }

        static bool contUser()
        {
            while (true)
            {
                Console.Write("\n\nDo you want to stay logged into the User portal? (Enter 'yes' or 'no'): ");                        //Prompts for user input to continue or not
                string moreUser = Console.ReadLine();
                moreUser = moreUser.ToLower();                           //Converts input case to only lower case

                if (moreUser == "y" || moreUser == "yes")                //Checks the condition to continue User portal or quit
                {
                    return true;
                }
                else if (moreUser == "n" || moreUser == "no")
                {
                    return false;
                }
                else
                {
                    Console.Write("Please enter only y or n!");                //Prompts user to only enter a y (yes ) or n (no) if another character is entered
                }
            }
        }

        static bool contAdmin()
        {
            while (true)
            {
                Console.Write("\n\nDo you want to stay logged into the Admin portal? (Enter 'yes' or 'no'): ");                        //Prompts for user input to continue or not
                string moreAdmin = Console.ReadLine();
                moreAdmin = moreAdmin.ToLower();                           //Converts input case to only lower case

                if (moreAdmin == "y" || moreAdmin == "yes")                //Checks the condition to continue Admin portal or quit
                {
                    return true;
                }
                else if (moreAdmin == "n" || moreAdmin == "no")
                {
                    return false;
                }
                else
                {
                    Console.Write("Please enter only y or n!");                //Prompts user to only enter a y (yes ) or n (no) if another character is entered
                }
            }
        }
        public static void TopLevelMenu(List<Movie> AllMovies, string login)
        {

            if (login == "u" || login == "U")
            {
                do
                {

                    //Goto UserMenu Funtions
                    Console.Write("\nPlease choose a method to filter movies by: (N)ame, (A)ctor, (G)enre, or (D)irector: ");
                    string filter = Console.ReadLine();

                    if (filter == "n" || filter == "N")
                    {
                        //Goto Admin Add Function
                        Console.Write("\nPlease enter the movie name to filter by: ");
                        //Console.Write("Title: ");
                        string FilterName = Console.ReadLine();
                        User.FilterMovieName(AllMovies, FilterName);
                    }

                    if (filter == "a" || filter == "A")
                    {
                        //Goto Admin Add Function
                        Console.Write("\nPlease enter the actor name to filter by: ");
                        //Console.Write("Actor: ");
                        string FilterName = Console.ReadLine();
                        User.FilterMainActor(AllMovies, FilterName);
                    }

                    if (filter == "g" || filter == "G")
                    {
                        //Movie GenreFilter = mymovie as Movie;
                        Console.Write("Please enter the movie genre to filter by: ");
                        string FilterName = Console.ReadLine();
                        //string _GenreFilterStr = Console.ReadLine();
                        FilterName = FilterName.ToUpper();

                        User.FilterGenre(AllMovies, FilterName);
                    }

                    if (filter == "d" || filter == "D")
                    {
                        //Goto Admin Add Function
                        Console.Write("\nPlease enter the director name to filter by: ");
                        //Console.Write("Director: ");
                        string FilterName = Console.ReadLine();
                        User.FilterDirector(AllMovies, FilterName);
                    }

                } while (contUser());
            }
            if (login == "a" || login == "A")
            {
                do
                {


                    //Goto AdminMenu Functions
                    Console.Write("\nPlease choose an action: (F)ilter movies, (A)dd movie, (E)dit movie, or (D)elete movie: ");
                    string action = Console.ReadLine();

                    //Goto Admin Filter Functions
                    if (action == "f" || action == "F")
                    {
                        Console.Write("\nPlease choose a method to filter movies by: (N)ame, (A)ctor, (G)enre, or (D)irector: ");
                        string filter = Console.ReadLine();

                        if (filter == "n" || filter == "N")
                        {
                            //Goto Admin Add Function
                            Console.Write("\nPlease enter the movie name to filter by: ");
                            
                            string FilterName = Console.ReadLine();
                            Admin.FilterMovieAdmin(AllMovies, FilterName);
                        }


                        if (filter == "a" || filter == "A")
                        {
                            //Goto Admin Add Function
                            Console.Write("\nPlease enter the actor name to filter by: ");
                            
                            string FilterName = Console.ReadLine();
                            Admin.FilterActorAdmin(AllMovies, FilterName);
                        }

                        if (filter == "g" || filter == "G")
                        {
                            
                            Console.Write("Please enter the movie genre to filter by: ");
                            string FilterName = Console.ReadLine();
                            
                            FilterName = FilterName.ToUpper();

                            Admin.FilterGenreAdmin(AllMovies, FilterName);
                        }

                        if (filter == "d" || filter == "D")
                        {
                            //Goto Admin Add Function
                            Console.Write("\nPlease enter the director name to filter by: ");
                            
                            string FilterName = Console.ReadLine();
                            Admin.FilterDirectorAdmin(AllMovies, FilterName);
                        }
                    }

                    //Goto Admin AddMovie Function
                    if (action == "a" || action == "A")
                    {
                        Console.WriteLine("You chose to add a new movie.");
                        string _MovieName = "";
                        Console.WriteLine("\nPlease enter the following details for the movie:");
                        Console.Write("Title: ");
                        _MovieName = Console.ReadLine();
                         Admin.CheckMovieName(AllMovies, _MovieName);
                        

                        Console.Write("Main Actor: ");
                        string _MainActor = Console.ReadLine();

                        Console.Write("Genre: ");
                        string _GenreStr = Console.ReadLine();
                        _GenreStr = _GenreStr.ToUpper();

                        Console.Write("Director: ");
                        string _Director = Console.ReadLine();
                        Admin.AddMovie(AllMovies, _MovieName, _MainActor, _GenreStr, _Director);
                    }

                    //Goto Admin EditMovieName Function
                    if (action == "e" || action == "E")
                    {
                        Console.WriteLine("\nHere's the current movie repository listing.\n");
                        MoviesRepo.GetMovie(AllMovies);

                        Console.Write("\nPlease enter the number of the movie to edit: ");
                        string MovieUpd = Console.ReadLine();
                        int index = int.Parse(MovieUpd);
                        Movie mymovie;

                        mymovie = AllMovies[index - 1];
                        Console.WriteLine("\nHere is the movie you chose to edit:\n");
                        Console.WriteLine(mymovie);
                        string MovieToUpd = mymovie.MovieName;
                        Console.Write("\nPlease choose the field to edit: Movie (N)ame, Main (A)ctor, (G)enre (D)irector: ");
                        string entry = Console.ReadLine();
                        if (entry == "n" || entry == "N")
                        {
                            //Movie UpdMovie = mymovie as Movie;
                            Console.Write("Updated Title: ");
                            string UpdMovie = Console.ReadLine();
                            Admin.EditMovieName(AllMovies, index, MovieToUpd, UpdMovie);

                        }

                        //Goto EditMainActor Function
                        if (entry == "a" || entry == "A")
                        {
                            Movie UpdActor = mymovie as Movie;
                            Console.Write("Updated Actor: ");
                            string MainActorUpd = Console.ReadLine();
                            //UpdActor.MainActor = Console.ReadLine();


                            Admin.EditMainActor(AllMovies, index, MainActorUpd);


                        //Goto EditGenre Function
                        if (entry == "g" || entry == "G")
                        {
                            Movie UpdGenre = mymovie as Movie;
                            Console.Write("Updated Genre: ");
                            string _GenreStr = Console.ReadLine();
                            _GenreStr = _GenreStr.ToUpper();

                            Admin.EditGenre(AllMovies, index, _GenreStr);
                        }

                        //Goto EditDirector Function
                        if (entry == "d" || entry == "D")
                        {
                            Movie UpdDirector = mymovie as Movie;
                            Console.Write("Updated Director: ");
                            string DirectorUpd = Console.ReadLine();
                            //UpdDirector.Director = Console.ReadLine();

                            Admin.EditDirector(AllMovies, index, DirectorUpd);

                        }
                    }

                    //Goto Admin DeleteMovie Funtion
                    if (action == "d" || action == "D")
                    {
                        Console.WriteLine("\nHere's the current movie repository listing.\n");
                        MoviesRepo.GetMovie(AllMovies);
                        Console.Write("\nPlease enter the number of the movie to delete: ");
                        string MovieDel = Console.ReadLine();
                        int index = int.Parse(MovieDel);

                        Console.WriteLine("\nHere is the movie you chose to delete:\n");
                        Console.WriteLine(AllMovies[index - 1]);
                        Console.Write("\nPlease confirm movie deletion: (y/n) ");
                        string entry = Console.ReadLine();
                        if (entry == "y" || entry == "Y")
                        {
                            Admin.DeleteMovie(AllMovies, index);
                        }
                    }
                } while (contAdmin());
            }
        }

        static void Main(string[] args)
        {
            ////Initialize the list of 5 movies
            List<Movie> AllMovies = new List<Movie>();

            do
            {
                //Top Level Greeting Menu
                Console.WriteLine("***************************************************");
                Console.WriteLine("* Welcome to MockBuster's Online Movie Repository *");
                Console.WriteLine("***************************************************");

                MoviesRepo.GetMovie(AllMovies);
                //Choose User Menu or Admin Menu
                Console.Write("Please login as (U)ser or (A)dmin: ");
                string login = Console.ReadLine();
                TopLevelMenu(MoviesRepo.GetMovie(AllMovies), login);
            } while (contBuster());
            Console.WriteLine("\nGoodbye!! Thank you for stopping by MockBuster's Online Movie Repository!");

        }
    }
}
