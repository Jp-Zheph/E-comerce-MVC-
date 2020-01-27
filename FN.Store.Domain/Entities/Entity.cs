using System;

namespace FN.Store.Domain.Entities
{
	public class Entity
    {
		public int Id { get; set; }

		public DateTime Cadastro { get; set; } 
		

		public Entity()
		{
			Cadastro = DateTime.Now;
		}
	}
}
