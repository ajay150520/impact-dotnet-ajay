public static class Task117Demo
{
    public static void Run()
    {
        Console.WriteLine("----- Task 1.17: Partial, Access, Records and Indexers -----");

        // Part 1: Partial Employee
        Employee employee = new Employee(
            501,
            "Ajay",
            "Software Development"
        );

        employee.DisplayEmployee();
        Console.WriteLine($"Employee Info: {employee.GetEmployeeInfo()}");


        // Part 2: Access modifiers
        Console.WriteLine();
        AccessModifierMatrix accessDemo = new AccessModifierMatrix();
        accessDemo.DisplayInsideClass();

        Console.WriteLine();

        DerivedAccessModifierMatrix derivedDemo =
            new DerivedAccessModifierMatrix();

        derivedDemo.DisplayDerivedAccess();


        // Part 3: Address record
        Console.WriteLine();

        Address address1 = new Address(
            "12 Main Street",
            "Chennai",
            "600001"
        );

        Address address2 = new Address(
            "12 Main Street",
            "Chennai",
            "600001"
        );

        Console.WriteLine($"Address 1: {address1}");
        Console.WriteLine($"Address 2: {address2}");

        Console.WriteLine($"address1 == address2: {address1 == address2}");

        Address address3 = address1 with
        {
            City = "Bengaluru"
        };

        Console.WriteLine($"Address copied with 'with': {address3}");

        Console.WriteLine($"Original address: {address1}");


        // Part 4: Playlist indexers
        Console.WriteLine();

        Playlist playlist = new Playlist();

        Console.WriteLine($"Song at index 0: {playlist[0]}");
        Console.WriteLine($"Song at index 1: {playlist[1]}");

        playlist[1] = "Counting Stars";

        Console.WriteLine($"Updated song at index 1: {playlist[1]}");

        Console.WriteLine($"Playlist name: {playlist["Name"]}");
        Console.WriteLine($"Playlist genre: {playlist["Genre"]}");

        // Test bounds checking.
        try
        {
            Console.WriteLine($"Song at index 10: {playlist[10]}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Bounds check worked: {ex.Message}");
        }
    }
}