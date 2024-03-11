using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
public class Contact
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [EmailAddress]
    public string Email { get; set; }

    [Phone]
    public string PhoneNumber { get; set; }
}

public class PhoneBookContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        using (var context = new PhoneBookContext())
        {
            // Create
            var contact = new Contact { Name = "John Doe", Email = "john@example.com", PhoneNumber = "123-456-7890" };
            context.Contacts.Add(contact);
            context.SaveChanges();

            // Read
            Console.WriteLine("Contacts:");
            foreach (var savedContact in context.Contacts)
            {
                Console.WriteLine($"Id: {savedContact.Id}, Name: {savedContact.Name}, Email: {savedContact.Email}, Phone Number: {savedContact.PhoneNumber}");
            }

            // Update
            var contactToUpdate = context.Contacts.FirstOrDefault(c => c.Name == "John Doe");
            if (contactToUpdate != null)
            {
                contactToUpdate.PhoneNumber = "987-654-3210";
                context.SaveChanges();
            }

            // Delete
            var contactToDelete = context.Contacts.FirstOrDefault(c => c.Name == "John Doe");
            if (contactToDelete != null)
            {
                context.Contacts.Remove(contactToDelete);
                context.SaveChanges();
            }
        }
    }
}