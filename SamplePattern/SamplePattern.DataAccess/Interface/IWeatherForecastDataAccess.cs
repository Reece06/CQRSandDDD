using SamplePattern.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamplePattern.DataAccess.Interface
{
    public interface IWeatherForecastDataAccess
    {
        WeatherForeCast GetForecast(int id);
    }
}
