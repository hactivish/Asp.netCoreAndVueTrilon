using System.Collections.Generic;
using my_vue_starter.Models;

namespace my_vue_starter.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
