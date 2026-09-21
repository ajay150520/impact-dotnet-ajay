public class TemperatureConverter
{
    // Celsius to Fahrenheit
    public double Convert(double celsius, char targetUnit)
    {
        return targetUnit switch
        {
            'F' => (celsius * 9 / 5) + 32,
            'K' => celsius + 273.15,
            _ => throw new ArgumentException("Target unit must be F or K.")
        };
    }

    // Fahrenheit to Celsius
    public double Convert(float fahrenheit, char targetUnit)
    {
        return targetUnit switch
        {
            'C' => (fahrenheit - 32) * 5 / 9,
            'K' => ((fahrenheit - 32) * 5 / 9) + 273.15,
            _ => throw new ArgumentException("Target unit must be C or K.")
        };
    }

    // Kelvin to Celsius
    public double Convert(int kelvin, char targetUnit)
    {
        return targetUnit switch
        {
            'C' => kelvin - 273.15,
            'F' => ((kelvin - 273.15) * 9 / 5) + 32,
            _ => throw new ArgumentException("Target unit must be C or F.")
        };
    }

    public (double First, double Second) ConvertToOtherUnits(
        double value,
        char unit)
    {
        char normalizedUnit = char.ToUpper(unit);

        return normalizedUnit switch
        {
            'C' => (
                Convert(value, 'F'),
                Convert(value, 'K')
            ),

            'F' => (
                Convert((float)value, 'C'),
                Convert((float)value, 'K')
            ),

            'K' => (
                Convert((int)value, 'C'),
                Convert((int)value, 'F')
            ),

            _ => throw new ArgumentException(
                "Unit must be C, F, or K."
            )
        };
    }
}