namespace SchoolManagement
{
    public class Student
    {
        public string Name { get; set; } = string.Empty;

        public void DisplayStudent()
        {
            Console.WriteLine($"Student Name: {Name}");
        }
    }
}