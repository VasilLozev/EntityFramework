using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;
using P01_StudentSystem.Data.Models.Configuration;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        private const string ConnectionString =
           "Server=.;Database=StudentSystem;Trusted_Connection=True;";

        public StudentSystemContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentsCourses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ResourceConfiguration());
            // Not needed, name inferred by convention
            modelBuilder.Entity<Course>()
                .HasKey(c => c.CourseId);
            modelBuilder.Entity<StudentCourse>()
              .HasKey(sc => new { sc.StudentId, sc.CourseId });

        }
      /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }*/
    }
}
