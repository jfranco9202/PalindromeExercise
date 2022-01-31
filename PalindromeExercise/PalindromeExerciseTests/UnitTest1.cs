using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        public void MyTest(string word, bool expected)
        {
            //Arrange
            var tester = new UnitTest1();
            
            //Act
            bool actual = tester.WordSmith(word);

            //Assert
            Assert.Equal(expected, actual);

        }

        private bool WordSmith(string word)
        {
            throw new NotImplementedException();
        }
    }
}
