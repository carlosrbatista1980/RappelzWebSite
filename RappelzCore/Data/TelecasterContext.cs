using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RappelzCore.Repositories;

namespace RappelzCore.Data
{
    public class TelecasterContext : DbContext
    {
        public TelecasterContext(DbContextOptions<TelecasterContext> options) : base(options)
        {
        }

        //INSERT YOUR DbSets HERE

        public DbSet<Character> Character { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //INSERT YOUR Entities HERE

            modelBuilder.Entity<Character>().ToTable(nameof(Character));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=LOCALHOST; Database={RappelzConfiguration.DatabaseName.Telecaster()};User Id=sa;Password=;");
        }
    }
}
