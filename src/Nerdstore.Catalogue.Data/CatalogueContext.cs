using Microsoft.EntityFrameworkCore;
using NerdStore.Catalogue.Domain;
using NerdStore.Core.Data;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace Nerdstore.Catalogue.Data
{
    public class CatalogueContext : DbContext, IUnitOfWork
    {
        public CatalogueContext(DbContextOptions<CatalogueContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string)))
                property.Relational().ColumnType == "varchar(100)";
            
            base.OnModelCreating(modelBuilder);
        }
        
        public Task<bool> Commit()
        {
            throw new NotImplementedException();
        }
    }
}
