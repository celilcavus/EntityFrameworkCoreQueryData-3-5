using EFCoreQueryData.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreQueryData.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(x=>x.Content).HasMaxLength(300);
            builder.Property(x=>x.Content).IsRequired();
            
        }
    }
}