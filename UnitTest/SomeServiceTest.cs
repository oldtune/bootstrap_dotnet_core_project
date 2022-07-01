using Services.Implementations;
using System.Threading;
using Xunit;

namespace UnitTest
{
    public class SomeServiceTest
    {
        //Facts are tests which are always true. They test invariant conditions.
        [Fact]
        public void Return3_ShouldReturn3()
        {
            //Arrange
            var someService = new SomeService();

            //Act
            var result = someService.Return3();
            
            //Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Return3_FailCase()
        {
            //Arrange
            var someService = new SomeService();

            //Act
            var result = someService.Return3();

            //Assert
            Assert.Equal(4, result);
        }

        //Theories are tests which are only true for a particular set of data.
        [Theory]
        [InlineData(3, true)]
        [InlineData(4, true)]
        [InlineData(5, true)]
        [InlineData(100, false)]
        public void ReturnWhatEverTheInputLessThan10(int someValue, bool expected)
        {
            //Arrange
            var someService = new SomeService();
            //Act
            var result = someService.ReturnWhateverTheInputLessThan10(someValue);
            //Assert
            Assert.Equal(expected, someValue == result);
        }
    }
}