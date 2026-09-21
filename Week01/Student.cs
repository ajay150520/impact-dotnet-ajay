public class Student
{
    #region Fields

    public const string SchoolName = "Impact School";

    private readonly int studentId;

    #endregion


    #region Properties

    public string Name { get; set; } = string.Empty;

    private int age;

    public int Age
    {
        get => age;
        set
        {
            if (value < 5 || value > 100)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "Age must be between 5 and 100."
                );
            }

            age = value;
        }
    }

    public int Marks { get; set; }

    #endregion


    #region Constructors

    // Parameterless constructor chained to the parameterized constructor.
    public Student() : this("Unknown", 18, 100)
    {
    }

    // Parameterized constructor.
    public Student(string name, int age, int studentId)
    {
        Name = name;
        Age = age;
        this.studentId = studentId;
    }

    #endregion


    #region Methods

    // Overloaded CalculateGrade() - uses the student's Marks property.
    public string CalculateGrade()
    {
        return CalculateGrade(Marks);
    }

    // Overloaded CalculateGrade() - accepts marks as a parameter.
    public string CalculateGrade(int marks)
    {
        return marks switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };
    }

    public void DisplayStudent()
    {
        Console.WriteLine($"Student ID: {studentId}");
        Console.WriteLine($"Student Name: {Name}");
        Console.WriteLine($"Student Age: {Age}");
        Console.WriteLine($"Student Marks: {Marks}");
        Console.WriteLine($"Grade: {CalculateGrade()}");
        Console.WriteLine($"School: {SchoolName}");
    }

    // Explanation:
    // const fields cannot be changed after declaration.
    // readonly fields can be assigned during declaration or inside a constructor,
    // but cannot be reassigned later.
    //
    // Examples that would cause compile errors:
    //
    // SchoolName = "Another School";  // Error: const cannot be assigned.
    // studentId = 999;                // Error here: readonly field cannot be
    //                                  // reassigned outside its allowed initialization.

    #endregion
}