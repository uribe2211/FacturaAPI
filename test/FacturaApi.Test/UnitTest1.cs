using Xunit;
using FacturaApi.Controllers;
namespace FacturaApi.Test;

public class UnitTest1
{

    WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void GetWeatherForecast()
    {
        var returnValue = controller.Get();
        Assert.NotEmpty(returnValue);
    }

    [Fact]
    public void Test1()
    {

    }
}