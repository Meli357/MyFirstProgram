using MyUtilities;

namespace MyFirstProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            WeatherUtilities.Report("Firenze", 18, 50);
        }
    }
}