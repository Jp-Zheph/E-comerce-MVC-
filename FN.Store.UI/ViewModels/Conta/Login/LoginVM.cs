using System.ComponentModel.DataAnnotations;

namespace FN.Store.UI.ViewModels.Conta.Login
{
	public class LoginVm
	{
		[Required(ErrorMessage = "O {0} é obrigatório")]
		[StringLength(40, ErrorMessage = "Limite do {0} é de {1} caracteres")]
		[RegularExpression(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)", ErrorMessage = " Email inválido")]
		public string Email { get; set; }

		[Required(ErrorMessage = "A {0} é obrigatório")]
		[StringLength(40, ErrorMessage = "Limite da {0} é de {1} caracteres")]
		public string Senha { get; set; }

		public bool PermanecerLogado { get; set; }

		public string ReturnUrl { get; set; }
	}
}
