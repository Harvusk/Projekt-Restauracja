using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projekt_Restauracja.Models;

namespace Projekt_Restauracja.Models
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "restaurant.db");
            optionsBuilder.UseSqlite($"Data Source={path}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public static void EnsureAdminUser()
        {
            using (var context = new RestaurantContext())
            {
                if (!context.Users.Any(u => u.Role == "Admin"))
                {
                    var salt = PasswordHelper.GenerateSalt();
                    var hash = PasswordHelper.HashPassword("admin123", salt); // password: admin123

                    context.Users.Add(new User
                    {
                        Username = "admin",
                        PasswordHash = hash,
                        Salt = salt,
                        Role = "Admin"
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}