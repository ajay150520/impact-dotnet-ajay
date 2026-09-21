public static class TemperatureConverterDemo
{
    public static void Run()
    {
        Console.WriteLine("----- Mini Q2: Temperature Converter -----");

        TemperatureConverter converter = new TemperatureConverter();

        // Celsius -> Fahrenheit and Kelvin
        double celsius = 25;

        (double fahrenheitFromCelsius, double kelvinFromCelsius) =
            converter.ConvertToOtherUnits(celsius, 'C');

        Console.WriteLine(
            $"{celsius}°C = {fahrenheitFromCelsius:0.00}°F, {kelvinFromCelsius:0.00}K"
        );


        // Fahrenheit -> Celsius and Kelvin
        double fahrenheit = 77;

        (double celsiusFromFahrenheit, double kelvinFromFahrenheit) =
            converter.ConvertToOtherUnits(fahrenheit, 'F');

        Console.WriteLine(
            $"{fahrenheit}°F = {celsiusFromFahrenheit:0.00}°C, {kelvinFromFahrenheit:0.00}K"
        );


        // Kelvin -> Celsius and Fahrenheit
        double kelvin = 300;

        (double celsiusFromKelvin, double fahrenheitFromKelvin) =
            converter.ConvertToOtherUnits(kelvin, 'K');

        Console.WriteLine(
            $"{kelvin}K = {celsiusFromKelvin:0.00}°C, {fahrenheitFromKelvin:0.00}°F"
        );


        // Invalid unit test for later xUnit coverage.
        try
        {
            converter.ConvertToOtherUnits(100, 'X');
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Invalid unit rejected: {ex.Message}");
        }
    }
}