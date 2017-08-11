using Seafood.Models;
using Xunit;

namespace Seafood.Tests
{
    public class SubscriberTest
    {
        [Fact]
        public void GetNameTest()
        {
            //Arrange
            var subscriber = new Subscriber();

            //Act
            var result = subscriber.Name = "Louis";

            //Assert
            Assert.Equal("Louis", result);
        }
        [Fact]
        public void GetEmailTest()
        {
            //Arrange
            var subscriber = new Subscriber();

            //Act
            var result = subscriber.Email = "Louis@louis.com";

            //Assert
            Assert.Equal("Louis@louis.com", result);
        }
    }
}