using NerdStore.Core.DomainObjects;
using System;

namespace NerdStore.Catalogue.Domain
{
    public class Produto : Entity, IAgregateRoot
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public bool Ativo { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string Imagem { get; private set; }
        public int Quantidade { get; private set; }
        public Categoria Categoria { get; private set; }
        public Guid CategoriaId { get; private set; }
        public int QuantidadeEstoque { get; private set; }

        public Produto(string nome, string descricao, bool ativo, decimal valor, Guid categoriaId, DateTime dataCadastro, string imagem)
        {
            CategoriaId = categoriaId;
            Nome = nome;
            Descricao = descricao;
            Ativo = ativo;
            Valor = Valor;
            DataCadastro = dataCadastro;
            Imagem = imagem;
        }

        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;

        public void AtelrarCategoria(Categoria categoria)
        {
            Categoria = categoria;
            CategoriaId = categoria.Id;
        }

        public void AlterarDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public void DebitarEstoque(int quantidade)
        {
            if (quantidade < 0) quantidade *= -1;
            QuantidadeEstoque -= quantidade;
        }

        public bool ReporEstoque(int quantidade)
        {
            return QuantidadeEstoque >= quantidade;
        }

        public bool PossuiEstoque(int quantidade)
        {
            return QuantidadeEstoque >= quantidade;
        }

        public void Validar()
        {

        }
    }
}
