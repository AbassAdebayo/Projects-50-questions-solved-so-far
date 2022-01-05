using Microsoft.EntityFrameworkCore;
using MyBlog.Entities;

namespace MyBlog.Context
{
    public class MyAppContext: DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {    
        }


        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }
        
        public DbSet<Category> Categories { get; set; }
        
        public DbSet<BlogCategory> BlogCategories { get; set; }
    }
}