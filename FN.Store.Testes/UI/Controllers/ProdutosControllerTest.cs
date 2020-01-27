using FN.Store.Domain.Contracts.Repositories;
using FN.Store.Domain.Entities;
using FN.Store.UI.Controllers;
using FN.Store.UI.ViewModels.Produtos.Index;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FN.Store.Testes.UI.Controllers
{
	[TestClass]
    public class ProdutosControllerTest
    {
        
		//dado um ProdutoController
		[TestMethod]
		public void MetodoIndexDeveraRetornarAViewComModeloCorreto()
		{

			//arrenge
			var produtosController = new ProdutoController(new ProdutoRepositoryFake(), new TipoDeRepositoryFake());


			//act

			var result = produtosController.Index();

			var model = result.Model  as IEnumerable<ProdutoIndexVM>;

			//assert

			Assert.AreEqual(typeof(ViewResult), result.GetType());
			Assert.AreEqual(3, model.Count());
			Assert.IsNotNull(model);

		}

    }


	public class ProdutoRepositoryFake : IProdutoRepository
	{
		public void Add(Produto entity)
		{
			throw new System.NotImplementedException();
		}

		public void Delete(Produto entity)
		{
			throw new System.NotImplementedException();
		}

		public void Dispose()
		{
			throw new System.NotImplementedException();
		}

		public void Edit(Produto entity)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<Produto> Get()
		{
			var tipo1 = new TipoDeProduto() { Id = 1, Nome = "tipo 1" };
			var tipo2 = new TipoDeProduto() { Id = 2, Nome = "tipo 2" };
			return new List<Produto>()
			{
				new Produto(){Id = 1 , Nome = "produto 1" , Preco = 1 , Qtde = 10, TipoDeProdutoId = tipo1.Id,TipodeProduto = tipo1 },
				new Produto(){Id = 2 , Nome = "produto 2" , Preco = 2 , Qtde = 20, TipoDeProdutoId = tipo2.Id,TipodeProduto = tipo1 },
				new Produto(){Id = 3 , Nome = "produto 3" , Preco = 3 , Qtde = 30, TipoDeProdutoId = tipo1.Id,TipodeProduto = tipo1}
			};
		}

		public Produto Get(int id)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<Produto> GetByNameContains(string contains)
		{
			throw new System.NotImplementedException();
		}
	}
	public class TipoDeRepositoryFake : ITipoDeProdutoRepository
	{
		public void Add(TipoDeProduto entity)
		{
			throw new System.NotImplementedException();
		}

		public void Delete(TipoDeProduto entity)
		{
			throw new System.NotImplementedException();
		}

		public void Dispose()
		{
			throw new System.NotImplementedException();
		}

		public void Edit(TipoDeProduto entity)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<TipoDeProduto> Get()
		{
			throw new System.NotImplementedException();
		}

		public TipoDeProduto Get(int id)
		{
			throw new System.NotImplementedException();
		}
	}
}
