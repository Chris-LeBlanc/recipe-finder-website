using Microsoft.EntityFrameworkCore;


namespace RecipeFinder.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> o) : base(o) { }

        // public DbSet<Recipe> Recipe { get; set; }
    }
}