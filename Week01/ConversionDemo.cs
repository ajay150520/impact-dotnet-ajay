public static class ConversionDemo
{
    public static void Run()
    {
        Console.WriteLine("----- Task 1.12: Conversions -----");

        // Part 1: Implicit conversions
        int intValue = 100;
        long longValue = intValue;
        float floatValue = longValue;
        double doubleValue = floatValue;

        Console.WriteLine($"int value: {intValue}");
        Console.WriteLine($"long value: {longValue}");
        Console.WriteLine($"float value: {floatValue}");
        Console.WriteLine($"double value: {doubleValue}");

        // Explanation:
        // These conversions are implicit because the target type can represent
        // the source value in this example without requiring an explicit cast.


        // Part 2: Explicit conversion and precision loss
        double originalDouble = 123.9876;
        int convertedInt = (int)originalDouble;

        Console.WriteLine($"Original double: {originalDouble}");
        Console.WriteLine($"Converted int: {convertedInt}");

        // Explanation:
        // double to int is an explicit conversion because information may be lost.
        // The fractional part (.9876) is removed, so 123.9876 becomes 123.
        // This is a precision/information loss.


        // Part 3: String with 'is'
        string input = "12345";
        object inputObject = input;

        bool isString = inputObject is string;

        Console.WriteLine($"Using 'is': inputObject is string = {isString}");

        // Explanation:
        // 'is' checks whether an object is compatible with a specified type.
        // It is useful when we only want to check the type before using the value.


        // Part 4: String with 'as'
        string? asString = inputObject as string;

        Console.WriteLine($"Using 'as': {asString}");

        // Explanation:
        // 'as' attempts a reference-type conversion and returns null if the conversion fails.
        // It is useful when a failed cast should not throw an exception.


        // Part 5: Convert.ToInt32
        int convertedNumber = Convert.ToInt32(input);

        Console.WriteLine($"Using Convert.ToInt32: {convertedNumber}");

        // Explanation:
        // Convert.ToInt32 is useful when converting a value such as a numeric string
        // into an integer. Invalid input can throw a FormatException.


        // Part 6: int.TryParse
        bool parseSuccess = int.TryParse(input, out int parsedNumber);

        Console.WriteLine($"Using int.TryParse: Success = {parseSuccess}");
        Console.WriteLine($"Parsed value: {parsedNumber}");

        // Explanation:
        // TryParse attempts to convert a numeric string and returns true when successful.
        // It returns false instead of throwing an exception for invalid numeric input.
        // It is generally useful for user-entered or otherwise untrusted numeric text.
    }
}