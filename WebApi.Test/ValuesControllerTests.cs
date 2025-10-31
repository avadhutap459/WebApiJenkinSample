using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Controllers;

namespace WebApi.Test
{
    public class ValuesControllerTests
    {
        [Fact]
        public void Get_ReturnsTwoValues()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            var result = controller.Get();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            Assert.Contains("value1", result);
            Assert.Contains("value2", result);
        }
    }
}
