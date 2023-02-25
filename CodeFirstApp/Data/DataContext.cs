using CodeFirstApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
