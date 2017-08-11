using Seafood.Models;
using Xunit;

namespace Seafood.Tests
{
    public class SubscriberTest
    {
        [Fact]
        public void GetDescriptionTest()
        {
            //Arrange
            var subscriber = new Subscriber();

            //Act
            var result = subscriber.Name;

            //Assert
            Assert.Equal("Louis", result);
        }
    }
}