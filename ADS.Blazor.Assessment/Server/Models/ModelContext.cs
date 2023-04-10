using Microsoft.EntityFrameworkCore;

namespace ADS.Blazor.Assessment.Server.Models
{
    public class ModelContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlite("Filename=sqlite.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        #region Data seeding
        private static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasData(new Category()
                {
                    Id = 1,
                    Name = "Soda"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Chips"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Food"
                });
            modelBuilder.Entity<Product>()
                .HasData(new Product()
                {
                    Id = 1,
                    Name = "Dr. Pepper",
                    Price = 1.99,
                    Size = "20oz",
                    CategoryId = 1,
                }, new Product()
                {
                    Id = 2,
                    Name = "Coca-Cola",
                    Price = 1.99,
                    Size = "20oz",
                    CategoryId = 1,
                }, new Product()
                {
                    Id = 3,
                    Name = "Coca-Cola",
                    Price = 6.99,
                    Size = "24pk",
                    CategoryId = 1,
                }, new Product()
                {
                    Id = 4,
                    Name = "Dr. Pepper",
                    Price = 7.99,
                    Size = "24pk",
                    CategoryId = 1,
                }, new Product()
                {
                    Id = 5,
                    Name = "Lays Cheddar & Sour Cream",
                    Price = 4.99,
                    Size = "8oz",
                    CategoryId = 2
                }, new Product()
                {
                    Id = 6,
                    Name = "Lays Salt & Vinegar",
                    Price = 4.99,
                    Size = "8oz",
                    CategoryId = 2
                }, new Product()
                {
                    Id = 7,
                    Name = "Doritos",
                    Price = 4.99,
                    Size = "8oz",
                    CategoryId = 2
                }, new Product()
                {
                    Id = 8,
                    Name = "Prego Traditional",
                    Price = 4.29,
                    Size = "16oz",
                    CategoryId = 3
                }, new Product()
                {
                    Id = 9,
                    Name = "Ragu Traditional",
                    Price = 3.50,
                    Size = "16oz",
                    CategoryId = 3
                }, new Product()
                {
                    Id = 10,
                    Name = "Barilla Pasta",
                    Price = 1.80,
                    Size = "16oz",
                    CategoryId = 3
                });
        }
        #endregion
    }
}
