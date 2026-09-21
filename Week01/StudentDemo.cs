public static class StudentDemo
{
    public static void Run()
    {
        Console.WriteLine("----- Task 1.16: Student Class -----");

        // Parameterless constructor uses constructor chaining.
        Student defaultStudent = new Student();

        Console.WriteLine("Default student created using chained constructor:");
        defaultStudent.DisplayStudent();

        // Parameterized constructor.
        Student student = new Student("Ajay", 26, 101);
        student.Marks = 85;

        Console.WriteLine();
        Console.WriteLine("Student created using parameterized constructor:");
        student.DisplayStudent();

        // Test overloaded CalculateGrade() methods.
        Console.WriteLine();
        Console.WriteLine($"CalculateGrade() = {student.CalculateGrade()}");
        Console.WriteLine($"CalculateGrade(95) = {student.CalculateGrade(95)}");

        // Test age validation.
        Console.WriteLine();
        Console.WriteLine("Testing invalid age...");

        try
        {
            student.Age = 101;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Age validation rejected the value: {ex.Message}");
        }

        // Valid age update.
        student.Age = 30;
        Console.WriteLine($"Valid age update: {student.Age}");

        // const value.
        Console.WriteLine($"SchoolName const value: {Student.SchoolName}");

        // readonly field is assigned through the constructor and displayed
        // through DisplayStudent().
    }
}