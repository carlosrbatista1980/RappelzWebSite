using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RappelzCore.Repositories;

namespace RappelzCore.Data
{
    public class ArcadiaContext : DbContext
    {
        public ArcadiaContext(DbContextOptions<ArcadiaContext> options) : base(options)
        {
        }
        
        public void ConfigureServices(IServiceCollection service)
        {
            service.AddDbContext<ArcadiaContext>(opt =>
            {
                opt.UseSqlServer($"Server=LOCALHOST; Database={RappelzConfiguration.DatabaseName.Arcadia};User Id=sa;Password=;");
            });
        }

        //INSERT YOUR DbSets HERE!
        public DbSet<Account> Account { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Insert YOUR ENTITIES HERE!

            //modelBuilder.Entity<Account>().ToTable(nameof(Account));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=LOCALHOST; Database={RappelzConfiguration.DatabaseName.Arcadia};User Id=sa;Password=;");
        }
    }
}
