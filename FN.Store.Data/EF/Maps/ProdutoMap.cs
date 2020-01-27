using FN.Store.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FN.Store.Data.EF.Maps
{
	public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
		public ProdutoMap()
		{
			//tabel
			ToTable(nameof(Produto));


			//Pk
			HasKey(pk => pk.Id);

			//coluna
			Property(c => c.Id)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

			Property(c => c.Nome)
				.HasColumnType("varchar")
				.HasMaxLength(100)
				.IsRequired();

			Property(c => c.Preco)
				.HasColumnType("money");

			Property(c => c.Qtde)
				.HasColumnName("Quantidade");

			Property(c => c.TipoDeProdutoId);

			Property(c => c.Cadastro);
				
			//relacionamento

			HasRequired(prod => prod.TipodeProduto)
				.WithMany(tipo => tipo.Produtos)
				.HasForeignKey(fk => fk.TipoDeProdutoId);
		}
    }
}
