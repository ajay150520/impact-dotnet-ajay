#define TRIAL_VERSION

using SchoolManagement;

class Program
{
    static void Main()
    {
        // Task 1.5 - Namespace and using directive

        // With using directive: only the class name is required.
        Student student1 = new Student();
        student1.Name = "Ajay";
        student1.DisplayStudent();

        // Without using directive: the fully qualified namespace name is required.
        SchoolManagement.Student student2 = new SchoolManagement.Student();
        student2.Name = "Ajay Kumar";
        student2.DisplayStudent();

        // Difference:
        // 'using SchoolManagement;' allows Student to be referenced directly.
        // Without 'using', SchoolManagement.Student must be used.


        // Task 1.6 - Resolving Helper name clash

        // Fully qualified names identify the correct Helper class.
        ModuleA.Helper.Greet();
        ModuleB.Helper.Greet();


        // Task 1.7 - Variable naming conventions

        // Local variables use camelCase.
        int studentAge = 26;
        string studentName = "Ajay";
        bool isEnrolled = true;
        double studentGpa = 8.5;
        int studentCount = 2;

        // 'class' is a C# keyword, so it cannot be used directly as a variable name.
        // '@class' escapes the keyword and allows it to be used as an identifier.
        int @class = 10;

        Console.WriteLine($"Student Name: {studentName}");
        Console.WriteLine($"Student Age: {studentAge}");
        Console.WriteLine($"Enrolled: {isEnrolled}");
        Console.WriteLine($"Student GPA: {studentGpa}");
        Console.WriteLine($"Student Count: {studentCount}");
        Console.WriteLine($"Class: {@class}");


        // Task 1.8 - Preprocessor directives

#if TRIAL_VERSION
        Console.WriteLine("Trial version enabled.");
#else
        Console.WriteLine("Standard version enabled.");
#endif

        // Task 1.8 - #region demonstration
        StudentRecord record = new StudentRecord(101, "Ajay");
        record.Display();

// Task 1.9 - Memory model
MemoryDemo.Run();

// Task 1.10 - Enums
EnumDemo.Run();

// Task 1.11 - Nullable values
NullableDemo.Run();

// Task 1.12 - Conversions
ConversionDemo.Run();

// Task 1.13 - var and dynamic
ModernSyntaxDemo.Run();

// Task 1.14 - Tuples and deconstruction
TupleDemo.Run();

// Task 1.15 - Pattern matching
PatternMatchingDemo.Run();

// Task 1.16 - Student class
StudentDemo.Run();

// Task 1.15 - Pattern matching
PatternMatchingDemo.Run();

// Task 1.16 - Student class
StudentDemo.Run();

// Task 1.17 - Partial, access modifiers, records and indexers
Task117Demo.Run();

// Mini Q1 - Product Catalog
ProductCatalogDemo.Run();

// Mini Q2 - Temperature Converter
TemperatureConverterDemo.Run();

// Mini Q3 - Contact Card
ContactCardDemo.Run();
    }
}


class StudentRecord
{
    #region Fields

    private int studentId;

    #endregion


    #region Properties

    public string StudentName { get; set; } = string.Empty;

    #endregion


    #region Constructors

    public StudentRecord(int studentId, string studentName)
    {
        this.studentId = studentId;
        StudentName = studentName;
    }

    #endregion


    #region Methods

    public void Display()
    {
        Console.WriteLine($"Student ID: {studentId}");
        Console.WriteLine($"Student Name: {StudentName}");
    }

    #endregion
}