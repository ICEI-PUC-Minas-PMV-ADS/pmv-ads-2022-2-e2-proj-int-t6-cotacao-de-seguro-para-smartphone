using Microsoft.EntityFrameworkCore;
using SeguroCelular.Mvc.Models;

namespace SeguroCelular.Mvc.Models.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<CotacaoSeguro> Cotacoes { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<SeguroCelular.Mvc.Models.CotacaoSeguro> CotacaoSeguro { get; set; }
    }
}
