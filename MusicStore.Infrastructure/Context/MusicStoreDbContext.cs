using Microsoft.EntityFrameworkCore;
using MusicStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Infrastructure.Context
{
    public class MusicStoreDbContext : DbContext 
    {
        public MusicStoreDbContext(DbContextOptions<MusicStoreDbContext> options) : base (options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductLink> ProductLinks { get; set; }
        public DbSet<UserNotification> UserNotifications { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
    }
}
