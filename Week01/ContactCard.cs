public struct ContactCard
{
    public string Name { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public ContactCard(string name, string phone, string email)
    {
        Name = name;
        Phone = phone;
        Email = email;
    }
}

public static class ContactCardSearch
{
    public static bool TryFindByName(
        ContactCard[] contacts,
        string name,
        out ContactCard contact)
    {
        foreach (ContactCard currentContact in contacts)
        {
            if (string.Equals(
                    currentContact.Name,
                    name,
                    StringComparison.OrdinalIgnoreCase))
            {
                contact = currentContact;
                return true;
            }
        }

        contact = default;
        return false;
    }
}