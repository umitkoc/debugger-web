using entity;
using Microsoft.EntityFrameworkCore;

namespace data.Concrete
{
    public class BlogContext:DbContext
    {

        public DbSet<Blog> Blog { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Music> Music { get; set; }
        public DbSet<Social> Social { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<About> About { get; set; }


        public BlogContext(DbContextOptions<BlogContext> options):base(options)
        {
            
        }
    }
}