using NerdStore.Core.DomainObjects;
using System;

namespace NerdStore.Catalogue.Domain.Events
{
    public class ProdutoAbaixoEtoqueEvent : DomianEvent
    {
        public int QuantidadeRestante { get; private set; }
        public ProdutoAbaixoEtoqueEvent(Guid  aggregateId, int quantidadeRestante) : base(aggregateId)
        {
            QuantidadeRestante = quantidadeRestante;
        }
    }
}
