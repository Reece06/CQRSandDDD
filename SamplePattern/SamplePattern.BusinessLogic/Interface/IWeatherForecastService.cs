using SamplePattern.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamplePattern.BusinessLogic.Interface
{
    public interface IWeatherForecastService
    {
        WeatherForeCast GetForeCast(int id);
    }
}
