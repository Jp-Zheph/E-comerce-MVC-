using FN.Store.Domain.Entities;
using FN.Store.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FN.Store.Data.EF
{
	internal class DbInitializer : CreateDatabaseIfNotExists<FNStoreDataContext>
	{
		protected override void Seed(FNStoreDataContext context)
		{
			var alimento = new TipoDeProduto() { Nome = "Alimento" };
			var Higiene = new TipoDeProduto() { Nome = "Higiene" };
			var eletrônico = new TipoDeProduto() { Nome = "Eletrônico" };
			var Limpeza = new TipoDeProduto() { Nome = "Limpeza" };

			var produtos = new List<Produto>() {
				new Produto(){ Nome = "Picanha" ,Preco = 30.90M, Qtde = 150 , TipodeProduto = alimento},
				new Produto(){ Nome = "Arroz" ,Preco = 9.90M, Qtde = 550 , TipodeProduto = alimento},
				new Produto(){ Nome = "Papel Higienico" ,Preco = 8.75m, Qtde = 220 ,TipodeProduto = Higiene},
				new Produto(){ Nome = "Telefone Sem fio" ,Preco = 199.90m, Qtde = 20 , TipodeProduto = eletrônico},
				new Produto(){ Nome = "Computador" ,Preco = 1270.00m, Qtde = 50 , TipodeProduto = eletrônico},
				new Produto(){ Nome = "PenDrive 8g" ,Preco = 50.00m, Qtde = 250 , TipodeProduto = eletrônico},
				new Produto(){ Nome = "Detergente" ,Preco = 3.00m, Qtde = 540 , TipodeProduto = Limpeza},

			};
			context.Produtos.AddRange(produtos);


			context.Usuarios.Add(new Usuario()
			{
				Nome = "Jota",
				Email = "jota@gmail.com",
				Senha = "123456".Encrypt()
			});



			context.SaveChanges();
		}
	}
}

