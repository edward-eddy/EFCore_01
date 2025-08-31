using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.Configurations
{
    internal class StudentConfigs : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> Student)
        {
            Student.Property(S => S.Id).UseIdentityColumn(10, 10);

            Student.Property(S => S.FName)
                   .IsRequired()
                   .HasColumnType("nvarchar")
                   .HasMaxLength(20);

            Student.Property(S => S.LName)
                   .IsRequired()
                   .HasColumnType("nvarchar")
                   .HasMaxLength(20);

            Student.Property(S => S.Age)
                   .HasDefaultValue(20);
        }
    }
}
