using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SamplePattern.BusinessLogic;
using SamplePattern.BusinessLogic.Interface;
using SamplePattern.DataAccess.Interface;
using SamplePattern.DataLayer.Entities;

namespace SamplePattern.UnitTest
{
    [TestClass]
    public class WeatherForecastService_Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mock<IWeatherForecastDataAccess> weatherDataAccessMock = new Mock<IWeatherForecastDataAccess>();
            weatherDataAccessMock.Setup(x => x.GetForecast(1)).Returns(It.IsAny<WeatherForeCast>);

            IWeatherForecastService weatherForecastService = new WeatherForecastService(weatherDataAccessMock.Object);
            weatherForecastService.GetForeCast(1);

            weatherDataAccessMock.VerifyAll();
        }
    }
}
