using Microsoft.Extensions.Logging;
using TodoApi.Controllers;

namespace TodoApiTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var logger = NSubstitute.Substitute.For<ILogger<WeatherForecastController>>();
        var controller = new WeatherForecastController(logger);

        var items = controller.Get();
        Assert.IsNotNull(items);
        Assert.IsTrue(items?.Count() > 0);
    }
}