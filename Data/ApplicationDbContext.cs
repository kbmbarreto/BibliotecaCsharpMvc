using BibliotecaCsharpMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaCsharpMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<BookModel> Books { get; set; }
    }
}
