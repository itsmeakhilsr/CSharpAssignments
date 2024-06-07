namespace Assignment_3_temperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter");
            Console.Write("Enter current temperature: ");
            double temperature = float.Parse(Console.ReadLine());
            Console.WriteLine("Select the conversion choice:");
            Console.WriteLine("1 Convert to Celsius");
            Console.WriteLine("2 Convert to Fahrenheit\n\n");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    double celsius = ConvertToCelsius(temperature);
                    Console.WriteLine($"Temperature in Celsius= {celsius} °C");
                    break;
                case 2:
                    double fahrenheit = ConvertToFahrenheit(temperature);
                    Console.WriteLine($"Temperature in Fahrenheit = {fahrenheit} °F");
                    break;
                default:
                    Console.WriteLine("Enterr a valid choice!");
                    break;
            }
        }
        static double ConvertToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        static double ConvertToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}
