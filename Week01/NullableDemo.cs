public static class NullableDemo
{
    public static void Run()
    {
        Console.WriteLine("----- Task 1.11: Nullable Values -----");

        // Part 1: Nullable int with HasValue

        int? studentAge = null;

        Console.WriteLine($"studentAge has value: {studentAge.HasValue}");

        if (studentAge.HasValue)
        {
            Console.WriteLine($"Student Age: {studentAge.Value}");
        }
        else
        {
            Console.WriteLine("Student Age is not available.");
        }

        studentAge = 26;

        Console.WriteLine($"studentAge has value after assigning 26: {studentAge.HasValue}");

        if (studentAge.HasValue)
        {
            Console.WriteLine($"Student Age: {studentAge.Value}");
        }


        // Part 2: ApplyDiscount with ?? operator

        double nullDiscountResult = ApplyDiscount(null);
        Console.WriteLine($"Discount when null is passed: {nullDiscountResult}%");

        double valueDiscountResult = ApplyDiscount(10);
        Console.WriteLine($"Discount when 10 is passed: {valueDiscountResult}%");


        // Explanation:
        // int? allows an int variable to contain a value or null.
        // HasValue tells us whether the nullable variable currently contains a value.
        // The ?? operator uses the value on the left when it is not null.
        // Otherwise, it uses the default value on the right.
    }

    public static double ApplyDiscount(double? discount)
    {
        return discount ?? 5.0;
    }
}