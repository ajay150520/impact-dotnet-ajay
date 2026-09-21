using Xunit;

public class ContactCardTests
{
    private readonly ContactCard[] contacts =
    [
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
    ];


    [Fact]
    public void Search_ShouldFindExistingContact()
    {
        bool found = ContactCardSearch.TryFindByName(
            contacts,
            "AJAY",
            out ContactCard contact);

        Assert.True(found);
        Assert.Equal("AJAY", contact.Name);
    }


    [Fact]
    public void Search_ShouldReturnFalseForMissingContact()
    {
        bool found = ContactCardSearch.TryFindByName(
            contacts,
            "Kumar",
            out ContactCard contact);

        Assert.False(found);
        Assert.Equal(default, contact);
    }


    [Fact]
    public void Search_ShouldBeCaseInsensitive()
    {
        bool found = ContactCardSearch.TryFindByName(
            contacts,
            "ajay",
            out ContactCard contact);

        Assert.True(found);
        Assert.Equal("AJAY", contact.Name);
    }


    [Fact]
    public void Search_ShouldHandleMixedCase()
    {
        bool found = ContactCardSearch.TryFindByName(
            contacts,
            "aJaY",
            out ContactCard contact);

        Assert.True(found);
        Assert.Equal("AJAY", contact.Name);
    }
}