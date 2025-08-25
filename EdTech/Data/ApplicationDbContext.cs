using EdTech.Models;
using Microsoft.EntityFrameworkCore;

namespace EdTech.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) 
        {

        }

        public DbSet<Category>Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Web & App Development", DisplayOrder=1 },
                new Category { Id = 2, Name = "Product Management & Design", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Business & Marketing", DisplayOrder = 3 }
                );
        }
    }
}
