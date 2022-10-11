using SeguroCelular.Domain.Entities;

namespace SeguroCelular.Domain.Repositories
{
    public interface IClienteRepository
    {
        Task<Cliente> ObterPorId(Guid id);

        void Adicionar(Cliente cliente);
        void Atualizar(Cliente cliente);
    }
}
