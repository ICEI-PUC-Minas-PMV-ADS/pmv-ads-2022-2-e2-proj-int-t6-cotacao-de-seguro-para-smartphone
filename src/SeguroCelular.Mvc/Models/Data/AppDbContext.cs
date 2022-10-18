using Microsoft.EntityFrameworkCore;

namespace SeguroCelular.Mvc.Models.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
