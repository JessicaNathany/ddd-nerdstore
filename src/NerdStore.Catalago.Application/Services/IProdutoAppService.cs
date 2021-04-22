using NerdStore.Catalago.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NerdStore.Catalago.Application.Services
{
    public interface IProdutoAppService : IDisposable
    {
        Task<IEnumerable<ProdutoViewModel>> ObterPorCategoria(int codigo);
        Task<ProdutoViewModel> ObterPorId(Guid id);
        Task<IEnumerable<ProdutoViewModel>> ObterTodos();
        Task<IEnumerable<CategoriaViewModel>> ObterCategorias();
        Task AdicioanrProduto(ProdutoViewModel produtoViewModel);
        Task AtualizarProduto(ProdutoViewModel produtoViewModel);
        Task<ProdutoViewModel> DebitarEstoque(Guid guid, int quantidade);
        Task<ProdutoViewModel> ReporEstoque(Guid guid, int quantidade);
    }
}
