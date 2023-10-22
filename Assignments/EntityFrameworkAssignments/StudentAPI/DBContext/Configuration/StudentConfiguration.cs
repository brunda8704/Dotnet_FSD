using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentAPI.Models;

namespace StudentAPI.DBContext.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(500, 1);

            builder.Property(x => x.FirstName)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(x => x.LastName)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(x => x.TotalMarks)
                   .IsRequired();

            builder.Property(x => x.Age)
                   .IsRequired();
        }
    }
}
