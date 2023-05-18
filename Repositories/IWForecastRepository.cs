using WeatherApp.Models.OpenWeatherAppModel;

namespace WeatherApp.Repositories
{
    public interface IWForecastRepository
    {
        WeatherResponse GetForecast(string city);
    }
}
