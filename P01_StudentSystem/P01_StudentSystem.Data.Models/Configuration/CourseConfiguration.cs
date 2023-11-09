using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Data.Models;

namespace P01_StudentSystem.P01_StudentSystem.Data.Models.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
            public void Configure(EntityTypeBuilder<Course> builder)
            {
            builder.Property(s => s.StudentsCourses)
             .IsRequired(true);
        }
    }
}
