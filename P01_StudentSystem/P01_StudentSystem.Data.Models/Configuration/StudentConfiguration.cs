using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace P01_StudentSystem.Data.Models.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(s => s.Name)
                   .HasMaxLength(100)
                   .IsUnicode(true);

            builder.Property(s => s.PhoneNumber)
                   .IsFixedLength()
                   .IsRequired(false)
                   .IsUnicode(false);

            builder.Property(s => s.StudentsCourses)
                 .IsRequired(true);

        }
    }
}
