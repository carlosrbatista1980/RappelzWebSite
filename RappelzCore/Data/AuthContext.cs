using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RappelzCore.Repositories;

namespace RappelzCore.Data
{
    public class AuthContext : DbContext
    {
        public AuthContext(DbContextOptions<AuthContext> options) : base(options)
        {
            
        }

        //INSERT YOUR DbSets HERE!

        public DbSet<Account> Account { get; set; }
        public DbSet<Block> Block { get; set; }
        public DbSet<Download> Download { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //INSERT YOUR Entities HERE!

            modelBuilder.Entity<Account>().ToTable(nameof(Account));
            modelBuilder.Entity<Block>().ToTable(nameof(Block));
            modelBuilder.Entity<Download>().ToTable(nameof(Download));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=LOCALHOST; Database={RappelzConfiguration.DatabaseName.Auth};User Id=sa;Password=;");
        }
    }
}
