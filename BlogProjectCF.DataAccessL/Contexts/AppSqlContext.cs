using BlogProjectCF.EntityL.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BlogProjectCF.DataAccessL.Contexts
{
    public class AppSqlContext : DbContext
    {
        public AppSqlContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.Entity<Article>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Articles)
                .HasForeignKey(b => b.AuthorId);

            builder.Entity<Article>()
                .HasOne(b => b.Category)
                .WithMany(c => c.Articles)
                .HasForeignKey(b => b.CategoryId);





            builder.Entity<Author>().Property(e=> e.Id).IsRequired();
            builder.Entity<Author>().Property(e => e.Username).HasMaxLength(25).IsRequired();
            builder.Entity<Author>().Property(e => e.Password).IsRequired();
            builder.Entity<Author>().Property(e => e.CreatedDate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Entity<Author>().Property(e => e.UpdatedDate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Entity<Author>().Property(e => e.IsActive).IsRequired().HasDefaultValue(true);
            builder.Entity<Author>().Property(e => e.ImageUrl).IsRequired(false).HasDefaultValue("");
            builder.Entity<Author>().Property(e => e.Birthday).IsRequired(false);

            builder.Entity<Article>().Property(a => a.Id).IsRequired();
            builder.Entity<Article>().Property(a => a.Title).IsRequired();
            builder.Entity<Article>().Property(a => a.Description).IsRequired();
            builder.Entity<Article>().Property(a => a.Content).IsRequired();
            builder.Entity<Article>().Property(a => a.IsActive).IsRequired().HasDefaultValue(true);
            builder.Entity<Article>().Property(a => a.ImageUrl).IsRequired(false).HasDefaultValue("");
            builder.Entity<Article>().Property(a => a.AuthorId).IsRequired();
            builder.Entity<Article>().Property(a => a.CategoryId).IsRequired();
            builder.Entity<Article>().Property(a => a.CreatedDate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Entity<Article>().Property(a => a.UpdatedDate).IsRequired().HasDefaultValue(DateTime.Now);

            builder.Entity<Category>().Property(c => c.Id).IsRequired();
            builder.Entity<Category>().Property(c => c.Name).IsRequired();
            builder.Entity<Category>().Property(c => c.Description).IsRequired();
            builder.Entity<Category>().Property(c => c.CreatedDate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Entity<Category>().Property(c => c.UpdatedDate).IsRequired().HasDefaultValue(DateTime.Now);

            base.OnModelCreating(builder);
        }
        public DbSet<Article> Articles{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Author> Authors{ get; set; }
    }
}
