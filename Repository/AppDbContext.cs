using JsonApiCoreBooksSample.Domain;
using Microsoft.EntityFrameworkCore;


namespace JsonApiCoreBooksSample.Repository
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { } 

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Review> Reviews { get; set; }
    }
}
