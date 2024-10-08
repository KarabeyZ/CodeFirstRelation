using CodeFirstRelation.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelation.Data
{
    public class PatikaSecondDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ZEKERIYA\\SQLEXPRESS;Database=Library;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

       



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(user =>
            {
                user.ToTable("users");
                user.HasKey(user => user.Id);
                user.HasMany(u => u.Posts).WithOne(x => x.User).HasForeignKey(x => x.UserId);

            });
            modelBuilder.Entity<Post>(post =>
            {
                post.ToTable("post");
                post.HasKey(post => post.Id);
            });
                         
        }
    }
}
