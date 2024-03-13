using Spectre.Console;

namespace PhoneBook;

internal class ContactServce
{
    internal static void AddContact()
    {
        var contact = new Contact();
        contact.Name = AnsiConsole.Ask<string>("Contact's name:");
        contact.Email = AnsiConsole.Ask<string>("Contact's Email:");
        contact.PhoneNumber = AnsiConsole.Ask<string>("Contact's name:");

        ContactController.InsertContactInDatabase(contact);
    }

    internal static void DeleteContact()
    {
        throw new NotImplementedException();
    }

    internal static void UpdateContact()
    {
        throw new NotImplementedException();
    }

    internal static void ViewContact()
    {
        throw new NotImplementedException();
    }
    internal static void ViewAllContacts()
    {
        throw new NotImplementedException();
    }
}
