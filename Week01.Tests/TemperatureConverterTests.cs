using Xunit;

public class TemperatureConverterTests
{
    private readonly TemperatureConverter converter = new();


    [Fact]
    public void Celsius_ShouldConvertToFahrenheitAndKelvin()
    {
        (double fahrenheit, double kelvin) =
            converter.ConvertToOtherUnits(25, 'C');

        Assert.Equal(77, fahrenheit, 2);
        Assert.Equal(298.15, kelvin, 2);
    }


    [Fact]
    public void Fahrenheit_ShouldConvertToCelsiusAndKelvin()
    {
        (double celsius, double kelvin) =
            converter.ConvertToOtherUnits(77, 'F');

        Assert.Equal(25, celsius, 2);
        Assert.Equal(298.15, kelvin, 2);
    }


    [Fact]
    public void Kelvin_ShouldConvertToCelsiusAndFahrenheit()
    {
        (double celsius, double fahrenheit) =
            converter.ConvertToOtherUnits(300, 'K');

        Assert.Equal(26.85, celsius, 2);
        Assert.Equal(80.33, fahrenheit, 2);
    }


    [Fact]
    public void LowercaseUnit_ShouldAlsoWork()
    {
        (double fahrenheit, double kelvin) =
            converter.ConvertToOtherUnits(25, 'c');

        Assert.Equal(77, fahrenheit, 2);
        Assert.Equal(298.15, kelvin, 2);
    }


    [Fact]
    public void InvalidUnit_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            converter.ConvertToOtherUnits(100, 'X'));
    }
}