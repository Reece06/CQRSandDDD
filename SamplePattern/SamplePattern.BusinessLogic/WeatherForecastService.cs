using SamplePattern.BusinessLogic.Interface;
using SamplePattern.DataAccess.Interface;
using SamplePattern.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamplePattern.BusinessLogic
{
    public class WeatherForecastService: IWeatherForecastService
    {
        private readonly IWeatherForecastDataAccess weatherForecastDataAccess;

        public WeatherForecastService(IWeatherForecastDataAccess weatherForecastDataAccess)
        {
            this.weatherForecastDataAccess = weatherForecastDataAccess;
        }

        public WeatherForeCast GetForeCast(int id)
        {
            return weatherForecastDataAccess.GetForecast(1);
        }
    }
}
