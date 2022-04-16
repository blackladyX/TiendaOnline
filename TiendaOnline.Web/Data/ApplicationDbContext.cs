using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using TiendaOnline.Web.Models;

namespace TiendaOnline.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }
       
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>()
            .HasIndex(t => t.Name)
            .IsUnique();
            modelBuilder.Entity<Country>()
            .HasIndex(t => t.Name)
            .IsUnique();
            modelBuilder.Entity<Department>()
            .HasIndex(t => t.Name)
            .IsUnique();
        }
    }



}


