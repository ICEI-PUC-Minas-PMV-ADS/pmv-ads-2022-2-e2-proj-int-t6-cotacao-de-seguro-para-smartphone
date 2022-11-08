using Microsoft.EntityFrameworkCore;
using SeguroCelular.Mvc.Models;

namespace SeguroCelular.Mvc.Models.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<CotacaoSeguro> Cotacoes { get; set; }
        public DbSet<CotacaoSeguro> CotacaoSeguro { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
