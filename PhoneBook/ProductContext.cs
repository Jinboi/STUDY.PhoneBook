using Microsoft.EntityFrameworkCore;

namespace PhoneBook;
internal class ProductContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\LocalDBDemo;Integrated Security=True");
    }
}

x