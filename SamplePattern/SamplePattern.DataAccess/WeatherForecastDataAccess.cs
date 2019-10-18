using Microsoft.EntityFrameworkCore;
using SamplePattern.DataAccess.Interface;
using SamplePattern.DataLayer;
using SamplePattern.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamplePattern.DataAccess
{
    public class WeatherForecastDataAccess: IWeatherForecastDataAccess
    {
        private readonly DbContext dbContext;

        public WeatherForecastDataAccess(WeatherDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public WeatherForeCast GetForecast(int id)
        {
            throw new NotImplementedException();
        }
    }
}
