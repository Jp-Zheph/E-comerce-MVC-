using System;

namespace FN.Store.UI.ViewModels.Produtos.Index
{
	public class ProdutoIndexVM
	{
		public int Id { get; set; }
		public DateTime Cadastro { get; set; } = DateTime.Now;
		public string Tipo { get; set; }
		public string Nome { get; set; }
		public decimal Preco { get; set; }
		public short Qtde { get; set; }
	}
}
