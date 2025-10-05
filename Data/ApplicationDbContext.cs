using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;" +
                "Database=MVCapp;" +
                "TrustServerCertificate=True;" +
                "Trusted_Connection=True");
        }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Test1", },
                new Category { Id = 2, Name = "Test2", },
                new Category { Id = 3, Name = "Test3", }, 
                new Category { Id = 4, Name = "Test4", }, 
                new Category { Id = 5, Name = "Test5", }, 
                new Category { Id = 6, Name = "Test6", });
        }

    }
}
