using TestApi.Controllers;
using Xunit;

namespace TestApi.XTest
{
    public class UnitTest
    {
        [Fact]
        public async void Test1()
        {
            CalculateController controller = new CalculateController();


            // Act
            var result = controller.GetData(2, 3);

            // Assert

            Assert.Equal(result.Value, 5);
        }
    }
}