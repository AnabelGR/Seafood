using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Seafood.Controllers;
using Seafood.Models;
using Xunit;

namespace Seafood.Tests.ControllerTests
{
    public class ItemControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            ItemController controller = new ItemController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
