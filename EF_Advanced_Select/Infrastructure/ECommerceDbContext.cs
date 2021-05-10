using Domain;
using Infrastructure.EntitiyConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext()
        {
        }

        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Promotion> Promotions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfiguration).Assembly);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Amount = 5, Image = "https://i.ibb.co/6bgccSg/212.jpg", Price = 200, Title = "First Product", CreatedAt = new DateTime(2021, 05, 06), CategoryId = 1 },
                new Product { Id = 2, Amount = 6, Image = "https://i.ibb.co/KyQwzHG/21133206.jpg", Price = 210, Title = "Second Product", CreatedAt = new DateTime(2021, 05, 06), CategoryId = 1 },
                new Product { Id = 3, Amount = 6, Image = "https://i.ibb.co/kmctC6G/21256508.jpg", Price = 220, Title = "Third Product", CreatedAt = new DateTime(2021, 05, 06), CategoryId = 1 },
                new Product { Id = 4, Amount = 6, Image = "https://i.ibb.co/KNFCs43/cosmetic-40.jpg", Price = 220, Title = "Fourth Product", CreatedAt = new DateTime(2021, 05, 06), CategoryId = 2 },
                new Product { Id = 5, Amount = 6, Image = "https://i.ibb.co/r6N7p8M/jar-03.jpg", Price = 220, Title = "Fifth Product", CreatedAt = new DateTime(2021, 05, 06), CategoryId = 2 },
                new Product { Id = 6, Amount = 6, Image = "https://i.ibb.co/X2gYjMN/jar-13.jpg", Price = 220, Title = "Sixth Product", CreatedAt = new DateTime(2021, 05, 06), CategoryId = 3 },
                new Product { Id = 7, Amount = 6, Image = "https://i.ibb.co/hcRbLBg/jar-24.jpg", Price = 220, Title = "Seventh Product", CreatedAt = new DateTime(2021, 05, 06), CategoryId = 3 },
                new Product { Id = 8, Amount = 6, Image = "https://i.ibb.co/mCMyJHD/jar-25.jpg", Price = 220, Title = "Eigth Product", CreatedAt = new DateTime(2021, 05, 06), CategoryId = 4 },
                new Product { Id = 9, Amount = 6, Image = "https://i.ibb.co/qJVPFxJ/jar-36.jpg", Price = 220, Title = "Nineth Product", CreatedAt = new DateTime(2021, 05, 06), CategoryId = 5 }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Coffee"},
                new Category { Id = 2, Name = "Tea"},
                new Category { Id = 3, Name = "Milk"},
                new Category { Id = 4, Name = "Sweeteners"},
                new Category { Id = 5, Name = "Coffee Machines"}
            );

            modelBuilder.Entity<Promotion>().HasData(
                new Promotion { Id = 1, Discount = 50.55f, PromotionalText = "50.55$ discount", ProductId = 2 },
                new Promotion { Id = 2, Discount = 20, PromotionalText = "20.00$ discount", ProductId = 9 },
                new Promotion { Id = 3, Discount = 70.30f, PromotionalText = "70.30$ discount", ProductId = 3 }
            );

            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<Admin>().ToTable("Admins");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=ECommerce;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}