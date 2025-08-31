using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.Configurations
{
    internal class TopicConfigs : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> Topic)
        {
            Topic.HasKey(T => T.Id);

            Topic.Property(T => T.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);
        }
    }
}
