public class AccessModifierMatrix
{
    public string PublicValue = "public";

    private string PrivateValue = "private";

    protected string ProtectedValue = "protected";

    internal string InternalValue = "internal";

    protected internal string ProtectedInternalValue = "protected internal";

    private protected string PrivateProtectedValue = "private protected";

    public void DisplayInsideClass()
    {
        Console.WriteLine("Access from inside AccessModifierMatrix:");

        Console.WriteLine($"Public: {PublicValue}");
        Console.WriteLine($"Private: {PrivateValue}");
        Console.WriteLine($"Protected: {ProtectedValue}");
        Console.WriteLine($"Internal: {InternalValue}");
        Console.WriteLine($"Protected Internal: {ProtectedInternalValue}");
        Console.WriteLine($"Private Protected: {PrivateProtectedValue}");
    }
}

public class DerivedAccessModifierMatrix : AccessModifierMatrix
{
    public void DisplayDerivedAccess()
    {
        Console.WriteLine("Access from derived class:");

        Console.WriteLine($"Public: {PublicValue}");
        Console.WriteLine($"Protected: {ProtectedValue}");
        Console.WriteLine($"Internal: {InternalValue}");
        Console.WriteLine($"Protected Internal: {ProtectedInternalValue}");
        Console.WriteLine($"Private Protected: {PrivateProtectedValue}");

        // PrivateValue cannot be accessed here.
    }
}