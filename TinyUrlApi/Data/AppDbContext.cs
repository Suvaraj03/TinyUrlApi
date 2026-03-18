using Microsoft.EntityFrameworkCore;
using TinyUrlApi.Entity;

namespace TinyUrlApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Url> Urls { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }

}
