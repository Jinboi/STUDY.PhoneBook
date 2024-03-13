using Spectre.Console;

namespace PhoneBook;

internal class UserInterface
{
    static internal void ShowContactTable(List<Contact> contacts)
    {
        var table = new Table();
        table.AddColumn("Id");
        table.AddColumn("Name");
        table.AddColumn("Email");
        table.AddColumn("PhoneNumber");

        foreach (var contact in contacts)
        {
            table.AddRow(contact.Id.ToString(), contact.Name, contact.Email, contact.PhoneNumber);
        }

        AnsiConsole.Write(table);

        Console.WriteLine("Enter any key to continue");
        Console.ReadLine();
    }
}
