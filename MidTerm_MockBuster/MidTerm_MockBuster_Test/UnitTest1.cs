//using System;
//using Xunit;
//using MidTerm_MockBuster;
//using System.Linq;
//using System.Collections.Generic;

//namespace MidTerm_MockBuster_Test
//{
//    public class UnitTest1
//    {
//        //Tests for Adding Movie

//        [Theory]
//        [InlineData(new List<> {"The Rock", "Nicolas Cage", "Action", "Michael Bay" }, new List<> { "The Rock", "Nicolas Cage", "Action", "Michael Bay" })]
//        public void TestMovieName(List<string>, List<string> expected)
//        {
//            List<string> actual = new List<string> (Movie);

//            List<string> expectedList = new List<string>(expected);

//            Assert.Equal(expected, actual);
//        }

//        //Test for Movie Name

//        [Theory]
//        [InlineData("The Rock", "The Rock")]
//        public void TestFilterMovieName(string MovieName, string expected)
//        {
//            string actual = Methods.FilterMovieName(MovieName);

//            Assert.Equal(expected, actual);
//        }

//        //Test for Genre

//        [Theory]
//        [InlineData("Action", "Action")]
//        public void TestFilterMainActor(string MainActor, string expected)
//        {
//            string actual = Methods.FilterMovieName(MainActor);

//            Assert.Equal(expected, actual);
//        }

//        [Theory]
//        [InlineData("Action", "Action")]
//        public void TestFilterGenre(string Genre, string expected)
//        {
//            string actual = Methods.FilterGenre(Genre);

//            Assert.Equal(expected, actual);
//        }

//        //Test for Director


//        [Theory]
//        [InlineData("Michael Bay", "Michael Bay")]
//        public void TestFilterDirector(string Director, string expected)
//        {
//            string actual = Methods.FilterDirector(Director);

//            Assert.Equal(expected, actual);
//        }


//        /Test for Remove Movie
//        [Theory]
//        [InlineData("The Rock", "")]
//        public void TestDeleteMovie(string Moviename, string expected)
//        {
//            string actual = Methods.DeleteMovie(MovieName);

//            Assert.Equal(expected, actual);
//        }

//        //Test for Get Movie


//    }
//}
