using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Pg.GitHubActionsDemo.Functions.Tests
{
    public class DemoFunctionTests
    {
        [Fact]
        public void Run_EmptyRequest_ReturnValidResponse()
        {
            // Arrange
            var logger = new LoggerFactory().CreateLogger<DemoFunction>();
            var function = new DemoFunction(logger);

            var httpContext = new DefaultHttpContext();
            var request = httpContext.Request;

            // Act
            var result = function.Run(request);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Welcome to Azure Functions!", okResult.Value);
        }
    }
}