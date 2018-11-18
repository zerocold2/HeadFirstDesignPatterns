namespace DesignPatterns.Behavioral_Pattern.Observer
{
    /// <summary>
    /// This's Concrete Observer Class
    /// </summary>
    public class Display : IObserver
    {
        //It could be replaced with any abstract interface for showing data
        private WeatherData _weatherData;

        public Display(WeatherData weatherData)
        {
            _weatherData = weatherData;
        }

        public void Update()
        {
            _weatherData.GetHumidity();
            _weatherData.GetPressure();
            _weatherData.GetTemperature();
        }
    }
}