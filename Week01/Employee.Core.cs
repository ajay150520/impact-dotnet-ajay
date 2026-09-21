public partial class Employee
{
    private readonly int employeeId;

    public string Name { get; set; } = string.Empty;

    public string Department { get; set; } = string.Empty;

    // Partial method declaration.
    partial void OnEmployeeCreated();

    public Employee(int employeeId, string name, string department)
    {
        this.employeeId = employeeId;
        Name = name;
        Department = department;

        // Calling the partial method implemented in the other file.
        OnEmployeeCreated();
    }

    public void DisplayEmployee()
    {
        Console.WriteLine($"Employee ID: {employeeId}");
        Console.WriteLine($"Employee Name: {Name}");
        Console.WriteLine($"Department: {Department}");
    }
}