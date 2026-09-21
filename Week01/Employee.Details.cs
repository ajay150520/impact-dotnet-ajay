public partial class Employee
{
    partial void OnEmployeeCreated()
    {
        Console.WriteLine($"Partial method called for employee: {Name}");
    }

    public string GetEmployeeInfo()
    {
        return $"{Name} - {Department}";
    }
}