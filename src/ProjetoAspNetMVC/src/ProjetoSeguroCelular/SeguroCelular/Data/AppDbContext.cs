using Microsoft.EntityFrameworkCore;
using SeguroCelular.Models;

namespace SeguroCelular.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ClienteViewModel> Clientes { get; set; }
    }
}
