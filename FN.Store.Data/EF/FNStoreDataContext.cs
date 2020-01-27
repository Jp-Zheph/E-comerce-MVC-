using FN.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FN.Store.Data.EF
{
	public class FNStoreDataContext : DbContext
	{
		public FNStoreDataContext() : base("StoreConn")
		{
			Database.SetInitializer(new DbInitializer());
		}

		public DbSet<Produto> Produtos { get; set; }
		public DbSet<TipoDeProduto> TipoDeProdutos { get; set; }
		public DbSet<Usuario> Usuarios { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new Maps.ProdutoMap());
			modelBuilder.Configurations.Add(new Maps.TipoProdutoMap());
			modelBuilder.Configurations.Add(new Maps.UsuarioMap());
		}
	}
}
