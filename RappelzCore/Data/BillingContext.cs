using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RappelzCore.Repositories;

namespace RappelzCore.Data
{
    public class BillingContext : DbContext
    {
        public BillingContext(DbContextOptions<BillingContext> options) : base(options)
        {
        }

        //INSERT YOUR DbSets HERE

        //public DbSet<Account> Account { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //INSERT YOUR Entities HERE

            //modelBuilder.Entity<Account>().ToTable(nameof(Account));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=LOCALHOST; Database={RappelzConfiguration.DatabaseName.Billing()};User Id=sa;Password=;");
        }
    }
}
