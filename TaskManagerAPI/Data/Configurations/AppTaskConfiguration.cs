using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagerAPI.Data.Models;

namespace TaskManagerAPI.Data.Configurations
{
    public class AppTaskConfiguration : IEntityTypeConfiguration<AppTask>
    {
        public void Configure(EntityTypeBuilder<AppTask> builder)
        {
            builder.Property(T => T.Title)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(T => T.Description)
                .IsRequired(false)
                .HasMaxLength(150);

            builder.HasOne(T => T.User)
                .WithMany()
                .HasForeignKey(T => T.UserId);
        }
    }
}
