public static class TupleDemo
{
    public static void Run()
    {
        Console.WriteLine("----- Task 1.14: Tuples and Deconstruction -----");

        // Part 1: Get minimum and maximum values
        int[] numbers = { 10, 5, 25, 3, 18 };

        (int Min, int Max) result = GetMinMax(numbers);

        Console.WriteLine($"Minimum: {result.Min}");
        Console.WriteLine($"Maximum: {result.Max}");

        // Deconstruct the named tuple into separate variables.
        var (minimum, maximum) = GetMinMax(numbers);

        Console.WriteLine($"Deconstructed minimum: {minimum}");
        Console.WriteLine($"Deconstructed maximum: {maximum}");

        // Part 2: Employee lookup
        var employee = GetEmployee(101);

        // Deconstruct the returned tuple into separate variables.
        var (name, age, department) = employee;

        Console.WriteLine($"Employee Name: {name}");
        Console.WriteLine($"Employee Age: {age}");
        Console.WriteLine($"Employee Department: {department}");

        // Explanation:
        // A tuple can return multiple values from a method without creating a separate class.
        // Named tuple elements such as Min and Max can be accessed using those names.
        // Deconstruction assigns tuple elements directly to separate variables.
    }

    public static (int Min, int Max) GetMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }

            if (number > max)
            {
                max = number;
            }
        }

        return (min, max);
    }

    public static (string Name, int Age, string Department) GetEmployee(int employeeId)
    {
        if (employeeId == 101)
        {
            return ("Ajay", 26, "Software Development");
        }

        return ("Unknown", 0, "Unknown");
    }
}