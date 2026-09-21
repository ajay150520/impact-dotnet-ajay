public class Order
{
    public string Status { get; set; } = string.Empty;
    public double Amount { get; set; }
}

public static class PatternMatchingDemo
{
    public static void Run()
    {
        Console.WriteLine("----- Task 1.15: Pattern Matching -----");

        // Part 1: Type pattern matching
        HandleValue(100);
        HandleValue("Hello");
        HandleValue(25.5);
        HandleValue(null);

        // Part 2: Grade calculator using relational patterns
        Console.WriteLine($"Grade for 95: {CalculateGrade(95)}");
        Console.WriteLine($"Grade for 82: {CalculateGrade(82)}");
        Console.WriteLine($"Grade for 74: {CalculateGrade(74)}");
        Console.WriteLine($"Grade for 65: {CalculateGrade(65)}");
        Console.WriteLine($"Grade for 40: {CalculateGrade(40)}");

        // Part 3: Property patterns
        Order highValuePendingOrder = new Order
        {
            Status = "Pending",
            Amount = 1200
        };

        Order mediumValuePendingOrder = new Order
        {
            Status = "Pending",
            Amount = 700
        };

        Order completedOrder = new Order
        {
            Status = "Completed",
            Amount = 1200
        };

        Console.WriteLine(
            $"High-value pending order discount: {GetOrderDiscount(highValuePendingOrder)}%"
        );

        Console.WriteLine(
            $"Medium-value pending order discount: {GetOrderDiscount(mediumValuePendingOrder)}%"
        );

        Console.WriteLine(
            $"Completed order discount: {GetOrderDiscount(completedOrder)}%"
        );
    }


    // Part 1: Handle different runtime types
    public static void HandleValue(object? value)
    {
        switch (value)
        {
            case int number:
                Console.WriteLine($"Integer branch: {number}");
                break;

            case string text:
                Console.WriteLine($"String branch: {text}");
                break;

            case double decimalNumber:
                Console.WriteLine($"Double branch: {decimalNumber}");
                break;

            case null:
                Console.WriteLine("Null branch");
                break;

            default:
                Console.WriteLine("Unknown type");
                break;
        }

        // Explanation:
        // Type patterns allow the method to identify the runtime type of the object
        // and execute the matching branch.
    }


    // Part 2: Switch expression with relational patterns
    public static string CalculateGrade(int score)
    {
        return score switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };
    }


    // Part 3: Property patterns
    public static double GetOrderDiscount(Order order)
    {
        return order switch
        {
            { Status: "Pending", Amount: >= 1000 } => 10,
            { Status: "Pending", Amount: >= 500 } => 5,
            _ => 0
        };
    }
}