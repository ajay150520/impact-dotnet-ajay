public enum DaysOfWeek
{
    Sunday = 0,
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6
}

[Flags]
public enum FilePermission
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4
}

public static class EnumDemo
{
    public static void Run()
    {
        Console.WriteLine("----- Task 1.10: Enums -----");

        // Part 1: DaysOfWeek enum
        Console.Write("Enter a day number (0-6): ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int dayNumber) && dayNumber >= 0 && dayNumber <= 6)
        {
            DaysOfWeek day = (DaysOfWeek)dayNumber;
            Console.WriteLine($"Day: {day}");
        }
        else
        {
            Console.WriteLine("Please enter a valid number from 0 to 6.");
        }

        // Part 2: FilePermission flags
        FilePermission permissions = FilePermission.Read | FilePermission.Write;

        Console.WriteLine($"Combined permissions: {permissions}");

        // Check whether Read permission is present.
        bool canRead = (permissions & FilePermission.Read) == FilePermission.Read;

        Console.WriteLine($"Has Read permission: {canRead}");

        // Check whether Execute permission is present.
        bool canExecute = (permissions & FilePermission.Execute) == FilePermission.Execute;

        Console.WriteLine($"Has Execute permission: {canExecute}");

        // Explanation:
        // The | operator combines multiple flag values into one value.
        // The & operator checks whether a specific permission exists in the combined value.
    }
}