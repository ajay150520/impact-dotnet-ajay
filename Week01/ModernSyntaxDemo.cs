public static class ModernSyntaxDemo
{
    public static void Run()
    {
        Console.WriteLine("----- Task 1.13: var and dynamic -----");

        // Part 1: var
        var varValue = 100;

        Console.WriteLine($"varValue = {varValue}");
        Console.WriteLine($"varValue type = {varValue.GetType().Name}");

        // IMPORTANT:
        // The following line causes a compile error because 'var' is strongly typed
        // after its initial assignment. Uncomment it temporarily to observe the error.
        //
        // varValue = "Hello";


        // Part 2: dynamic
        dynamic dynamicValue = "Hello";

        Console.WriteLine($"dynamicValue = {dynamicValue}");
        Console.WriteLine($"dynamicValue type = {dynamicValue.GetType().Name}");

        dynamicValue = 123;

        Console.WriteLine($"dynamicValue = {dynamicValue}");
        Console.WriteLine($"dynamicValue type = {dynamicValue.GetType().Name}");

        dynamicValue = true;

        Console.WriteLine($"dynamicValue = {dynamicValue}");
        Console.WriteLine($"dynamicValue type = {dynamicValue.GetType().Name}");

        // Explanation:
        // var determines the variable's type at compile time and cannot be assigned
        // a value of another type later.
        //
        // dynamic defers type checking until runtime, so the same variable can hold
        // a string, then an int, then a bool.


        // Part 3: dynamic parameter
        Console.WriteLine($"Add(10, 20) = {Add(10, 20)}");
        Console.WriteLine($"Add(\"Hello \", \"Ajay\") = {Add("Hello ", "Ajay")}");

        // Explanation:
        // The Add method accepts dynamic parameters, so the + operation is resolved
        // at runtime based on the actual types passed to the method.
        // With integers, + performs numeric addition.
        // With strings, + performs string concatenation.
    }

    public static dynamic Add(dynamic firstValue, dynamic secondValue)
    {
        return firstValue + secondValue;
    }
}