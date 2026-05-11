using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace YumBlazor.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
                base.OnModelCreating(builder);
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Pizza" },
                new Category { Id = 2, Name = "Burger" },
                new Category { Id = 3, Name = "Pasta" },
                new Category { Id = 4, Name = "Salad" },
                new Category { Id = 5, Name = "Dessert" }
            );
        }
    }
}
