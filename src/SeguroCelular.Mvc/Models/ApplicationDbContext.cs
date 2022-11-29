using Microsoft.EntityFrameworkCore;
using SeguroCelular.Mvc.Models.Data;

namespace SeguroCelular.Mvc.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
