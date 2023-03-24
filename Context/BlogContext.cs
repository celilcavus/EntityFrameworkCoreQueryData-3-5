using EFCoreQueryData.Configuration;
using EFCoreQueryData.Entitys;
using Microsoft.EntityFrameworkCore;

namespace EFCoreQueryData.Context
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog>? Blogs { get; set; }
        public DbSet<Comment>? Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=AspEFCoreBlog;Trusted_Connection=True;TrustServerCertificate=True;");
            optionsBuilder.LogTo(System.Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BlogConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}