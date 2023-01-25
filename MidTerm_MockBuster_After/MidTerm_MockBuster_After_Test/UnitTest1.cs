//using System;
//using Xunit;
//using MidTerm_MockBuster;
//using System.Linq;
//using System.Collections.Generic;

//namespace MidTerm_MockBuster_Test
//{
//    //Test for Checking Duplicate MovieName
//    public class DupicateMovieTest
//    {

//    }
//    //Tests for Adding Movie
//    public class AddMovieTest
//        [Theory]
//        [InlineData(new List<Movie> { "The Rock", "Nicolas Cage", "Action", "Michael Bay" }, new List<Movie> { "The Rock", "Nicolas Cage", "Action", "Michael Bay" })]
//        public void TestAddMovie(List<string> Movie, List<string> expected)
//        {
//            List<string> actual = new List<string>(Movie);

//            List<string> expectedList = new List<string>(expected);

//            Assert.Equal(expected, actual);
//        }

//    //Test for Movie Name
//    public class FilterMovieNameTest
//    {
//        [Theory]
//        [InlineData("The Rock", "The Rock")]
//        public void TestFilterMovieName(string MovieName, string expected)
//        {
//            string actual = User.FilterMovieName(MovieName);

//            Assert.Equal(expected, actual);
//        }
//    }


//    //Test for MainnActor
//    public class FilterMainActorTest
//    {
//        [Theory]
//        [InlineData("Action", "Action")]
//        public void TestFilterMainActor(string MainActor, string expected)
//        {
//            string actual = User.FilterMovieName(MainActor);

//            Assert.Equal(expected, actual);
//        }
//    }


//    //Test for Genre
//    public class FilterGenreTest
//    {
//        [Theory]
//        [InlineData("Action", "Action")]
//        public void TestFilterGenre(string Genre, string expected)
//        {
//            string actual = User.FilterGenre(Genre);

//            Assert.Equal(expected, actual);
//        }
//    }

//     //Test for Director
//    public class FilterDirectorTest
//    {
//            [Theory]
//            [InlineData("Michael Bay", "Michael Bay")]
//            public void TestFilterDirector(string Director, string expected)
//            {
//                string actual = User.FilterDirector(Director);

//                Assert.Equal(expected, actual);
//            }
//    }

//    public class DeleteMovieTest
//    {
//        //Test for Remove Movie
//        [Theory]
//        [InlineData("The Rock", "")]
//        public void TestDeleteMovie(int index)
//        {
//            string actual = Admin.DeleteMovie(AllMovies, index);

//            Assert.Equal(expected, actual);
//        }
//    }


//        //Test for Get Movie


    
//}