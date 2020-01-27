using FN.Store.Domain.Entities;
using FN.Store.UI.ViewModels.Produtos.Index;
using System.Collections.Generic;
using System.Linq;

namespace FN.Store.UI.ViewModels.Produtos.Maps
{
	public static class Extemsions
    {
        public static IEnumerable<ProdutoIndexVM> ToProdutoIndexVMs(this IEnumerable<Produto> data)
		{
			return data.Select(p => new ProdutoIndexVM()
			{
				Id = p.Id,
				Nome = p.Nome,
				Preco = p.Preco,
				Tipo = p.TipodeProduto.Nome,
				Qtde = p.Qtde,
				Cadastro = p.Cadastro
			});
		}
    }
}
