using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Context
{
    public class MyContext: DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transcation> Transcations { get; set; }
        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasOne(a => a.Account)
                .WithOne(c => c.Customer)
                .HasForeignKey<Account>(c => c.IdCustomer)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Customer>()
                .HasMany(t => t.Transcations)
                .WithOne(c => c.Customer)
                .HasForeignKey(t => t.IdCustomer)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Item>()
               .HasMany(t => t.Transcations)
               .WithOne(i => i.Item)
               .HasForeignKey(t => t.IdItem)
               .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Role)
                .WithMany(r => r.Customers)
                .HasForeignKey(c => c.RoleID);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
