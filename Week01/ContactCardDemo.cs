public static class ContactCardDemo
{
    public static void Run()
    {
        Console.WriteLine("----- Mini Q3: Contact Card -----");

        ContactCard[] contacts =
        {
            new ContactCard(
                "AJAY",
                "9876543210",
                "ajay@example.com"),

            new ContactCard(
                "Priya",
                "9876543211",
                "priya@example.com"),

            new ContactCard(
                "Rahul",
                "9876543212",
                "rahul@example.com"),

            new ContactCard(
                "Suresh",
                "9876543213",
                "suresh@example.com"),

            new ContactCard(
                "Divya",
                "9876543214",
                "divya@example.com")
        };

        // Lowercase query should find the differently-cased "AJAY".
        string query = "ajay";

        if (ContactCardSearch.TryFindByName(
                contacts,
                query,
                out ContactCard foundContact))
        {
            Console.WriteLine($"Search query: {query}");
            Console.WriteLine("Contact found!");
            Console.WriteLine($"Name: {foundContact.Name}");
            Console.WriteLine($"Phone: {foundContact.Phone}");
            Console.WriteLine($"Email: {foundContact.Email}");
        }
        else
        {
            Console.WriteLine($"No contact found for: {query}");
        }

        // Test a name that does not exist.
        string missingQuery = "Kumar";

        if (ContactCardSearch.TryFindByName(
                contacts,
                missingQuery,
                out ContactCard missingContact))
        {
            Console.WriteLine($"Found: {missingContact.Name}");
        }
        else
        {
            Console.WriteLine($"No contact found for: {missingQuery}");
        }
    }
}