using DAL.Entities;
using DAL.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ExtraItem> ExtraItems { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<MenuDetail> MenuDetails { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // Address - OrderDetails
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Address)
                .WithMany(a => a.OrderDetails)
                .HasForeignKey(od => od.AddressId)
                .OnDelete(DeleteBehavior.Cascade);

            // ExtraItem - OrderDetails
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.ExtraItem)
                .WithMany(ei => ei.OrderDetails)
                .HasForeignKey(od => od.ExtraItemId)
                .OnDelete(DeleteBehavior.Cascade);

            // Menu - OrderDetails
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Menu)
                .WithMany(m => m.OrderDetails)
                .HasForeignKey(od => od.MenuId)
                .OnDelete(DeleteBehavior.Cascade);

            // Order - OrderDetails
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId)
                .OnDelete(DeleteBehavior.NoAction); // No cascade delete for Order


            // Admin kullanıcıyı ekleme
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Admin",
                    LastName = "User",
                    BirthDate = new DateTime(1980, 1, 1),
                    Photo = null,
                    Email = "admin@example.com",
                    Username = "admin",
                    Password = "admin123",
                    IsAdmin = true,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new User { Id = 2, FirstName = "John", LastName = "Doe", BirthDate = new DateTime(1990, 5, 15), Email = "john@example.com", Username = "john", Password = "password123", IsAdmin = false },
                new User { Id = 3, FirstName = "Jane", LastName = "Smith", BirthDate = new DateTime(1985, 7, 20), Email = "jane@example.com", Username = "jane", Password = "password123", IsAdmin = false },
                new User { Id = 4, FirstName = "Michael", LastName = "Brown", BirthDate = new DateTime(1975, 3, 10), Email = "michael@example.com", Username = "michael", Password = "password123", IsAdmin = false },
                new User { Id = 5, FirstName = "Emily", LastName = "Clark", BirthDate = new DateTime(1995, 8, 25), Email = "emily@example.com", Username = "emily", Password = "password123", IsAdmin = false }
            );

            modelBuilder.Entity<Address>().HasData(
                new Address { Id = 1, FullAddress = "123 Main St", City = "New York", Country = "USA", PostalCode = 10001, UserId = 2 },
                new Address { Id = 2, FullAddress = "456 Elm St", City = "Los Angeles", Country = "USA", PostalCode = 90001, UserId = 3 },
                new Address { Id = 3, FullAddress = "789 Pine St", City = "Chicago", Country = "USA", PostalCode = 60007, UserId = 4 },
                new Address { Id = 4, FullAddress = "321 Oak St", City = "Houston", Country = "USA", PostalCode = 77001, UserId = 5 },
                new Address { Id = 5, FullAddress = "654 Maple St", City = "Phoenix", Country = "USA", PostalCode = 85001, UserId = 2 }
            );

            modelBuilder.Entity<ExtraItem>().HasData(
                new ExtraItem { Id = 1, Name = "Cheese", AdditionalPrice = 1.00 },
                new ExtraItem { Id = 2, Name = "Bacon", AdditionalPrice = 1.50 },
                new ExtraItem { Id = 3, Name = "Mushrooms", AdditionalPrice = 1.25 },
                new ExtraItem { Id = 4, Name = "Avocado", AdditionalPrice = 2.00 },
                new ExtraItem { Id = 5, Name = "Onions", AdditionalPrice = 0.75 }
            );

            modelBuilder.Entity<Menu>().HasData(
                new Menu { Id = 1, Name = "Burger", Price = 8.99, Description = "Juicy beef burger", OrderCount = 10, ViewCount = 50 },
                new Menu { Id = 2, Name = "Pizza", Price = 12.99, Description = "Cheese and pepperoni", OrderCount = 20, ViewCount = 100 },
                new Menu { Id = 3, Name = "Pasta", Price = 10.99, Description = "Creamy Alfredo pasta", OrderCount = 15, ViewCount = 75 },
                new Menu { Id = 4, Name = "Salad", Price = 7.99, Description = "Fresh garden salad", OrderCount = 8, ViewCount = 40 },
                new Menu { Id = 5, Name = "Tacos", Price = 9.99, Description = "Spicy chicken tacos", OrderCount = 12, ViewCount = 60 }
            );

            modelBuilder.Entity<MenuDetail>().HasData(
                new MenuDetail { Id = 1, MenuId = 1, ExtraItemId = 1 },
                new MenuDetail { Id = 2, MenuId = 2, ExtraItemId = 2 },
                new MenuDetail { Id = 3, MenuId = 3, ExtraItemId = 3 },
                new MenuDetail { Id = 4, MenuId = 4, ExtraItemId = 4 },
                new MenuDetail { Id = 5, MenuId = 5, ExtraItemId = 5 }
            );



        }

    }
}
