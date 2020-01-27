using FN.Store.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace FN.Store.Data.EF.Maps
{
	public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
		public UsuarioMap()
		{
			//tabel
			ToTable(nameof(Usuario));


			//Pk
			HasKey(pk => pk.Id);

			//coluna
			Property(c => c.Id)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

			Property(c => c.Nome)
				.HasColumnType("varchar")
				.HasMaxLength(100)
				.IsRequired();


			Property(c => c.Email)
				.HasColumnType("varchar")
				.HasMaxLength(80)
				.IsRequired()
				.HasColumnAnnotation(
					IndexAnnotation.AnnotationName,
					new IndexAnnotation(new IndexAttribute("UQ_dbO.Usuario.Email") { IsUnique = true})
				);

			Property(c => c.Senha)
				.HasColumnType("char")
				.HasMaxLength(88)
				.IsRequired();


			Property(c => c.Cadastro);
		}
    }
}
