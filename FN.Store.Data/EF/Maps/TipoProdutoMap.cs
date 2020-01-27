using FN.Store.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FN.Store.Data.EF.Maps
{
	public class TipoProdutoMap : EntityTypeConfiguration<TipoDeProduto>
    {
		public TipoProdutoMap()
		{
			//table
			ToTable(nameof(TipoDeProduto));

			//pk

			HasKey(pk => pk.Id);

			//columns
			Property(c => c.Id)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

			Property(c => c.Nome)
				.HasColumnType("varchar")
				.HasMaxLength(100)
				.IsRequired();

			Property(c => c.Cadastro);
		}
    }
}
