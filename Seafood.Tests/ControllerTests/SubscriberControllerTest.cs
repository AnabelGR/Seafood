using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Seafood.Controllers;
using Seafood.Models;
using Xunit;

namespace Seafood.Tests.ControllerTests
{
    public class SubscriberControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            SubscriberController controller = new SubscriberController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
