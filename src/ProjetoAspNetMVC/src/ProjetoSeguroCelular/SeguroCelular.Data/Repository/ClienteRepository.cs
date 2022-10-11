using Microsoft.EntityFrameworkCore;
using SeguroCelular.Domain.Entities;
using SeguroCelular.Domain.Repositories;

namespace SeguroCelular.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Cliente> ObterPorId(Guid id)
        {
            return await _context.Clientes.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }
        public void Adicionar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChangesAsync();
        }

        public void Atualizar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChangesAsync();
        }
    }
}
