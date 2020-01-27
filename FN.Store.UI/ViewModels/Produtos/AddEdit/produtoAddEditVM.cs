using System;
using System.ComponentModel.DataAnnotations;

namespace FN.Store.UI.ViewModels.Produtos.AddEdit
{
	public class ProdutoAddEditVM
	{
		[Required]
		[StringLength(100)]

		public string Nome { get; set; }

		public decimal Preco { get; set; }

		public short Qtde { get; set; }

		[Display(Name ="Tipo De Produto")]
		public int TipoDeProdutoId { get; set; }

		public int Id { get; set; }

		public DateTime Cadastro { get; set; }


		public ProdutoAddEditVM()
		{
			Cadastro =  DateTime.Now;
		}
	}
}
