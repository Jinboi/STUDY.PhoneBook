using PhoneBook;
using Microsoft.EntityFrameworkCore;

namespace PhoneBook;

internal class ContactController
{
    internal static void InsertContactInDatabase(Contact contact)
    {
        using var db = new ContactContext();
        db.Add(contact);

        db.SaveChanges();
    }
    internal static List<Contact> GetContacts()
    {
        using var db = new ContactContext();

        var contacts = db.Contacts.ToList<Contact>();

        return contacts;        
    }
}
