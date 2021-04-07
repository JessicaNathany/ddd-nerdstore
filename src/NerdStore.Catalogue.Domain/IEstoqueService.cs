using System;
using System.Threading.Tasks;

namespace NerdStore.Catalogue.Domain
{
    public interface IEstoqueService : IDisposable
    {
        Task<bool> DepositarEstoque(Guid produtoId, int quantidade);
        Task<bool> ReporEstoque(Guid produtoId, int quantidade);
    }
}
