using System;

namespace MyUtilities
{
    public class WeatherUtilities
    {
        static float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            // var temperatureCelsius = temperatureFahrenheit - 32 / 1.8f;
            // return temperatureCelsius;
            return temperatureFahrenheit - 32 / 1.8f;
        }

        static float CelsiusToFahrenheit(float temperatureCelsius)
        {
            //var temperatureFahrenheit = temperatureCelsius * 1.8f + 32;
            //return temperatureFahrenheit;
            return temperatureCelsius * 1.8f + 32;
        }
        //lower the index, higher the comfort
        static float ComfortIndex(float temperatureFahrenheit, float humidityPercent)
        {
            //var comfortIndex = (temperatureFahrenheit + humidityPercent) / 4;
            //return comfortIndex;
            return (temperatureFahrenheit + humidityPercent);
        }

        static public void Report(string location, float temperatureCelsius, float humidity)
        {
            var temperatureFahrenheit = CelsiusToFahrenheit(temperatureCelsius);
            Console.WriteLine("Comfort Index for " + location + ": " + ComfortIndex(temperatureFahrenheit, humidity));
        }
    }
}