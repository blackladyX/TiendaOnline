using Matriculas.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Matriculas.Web.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course>().HasIndex(t => t.CourseCode).IsUnique();

            modelBuilder.Entity<Teacher>().HasIndex(t => t.TeacherIdentification).IsUnique();


        }
    }

}