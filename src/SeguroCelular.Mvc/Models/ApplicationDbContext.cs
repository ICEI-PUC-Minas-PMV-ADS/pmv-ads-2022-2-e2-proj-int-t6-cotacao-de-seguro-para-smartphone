using Microsoft.EntityFrameworkCore;

namespace SeguroCelular.Mvc.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
