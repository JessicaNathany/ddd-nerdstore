using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace NerdStore.Catalogue.Domain.Events
{
    public class ProdutoEventHahndler : INotificationHandler<ProdutoAbaixoEtoqueEvent>
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoEventHahndler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Handle(ProdutoAbaixoEtoqueEvent mensagem, CancellationToken cancellationToken)
        {
            var produto = await _produtoRepository.ObterPorId(mensagem.AggregateId);
            //Enviar um email para aqusição de mais produtos.
        }
    }
}
