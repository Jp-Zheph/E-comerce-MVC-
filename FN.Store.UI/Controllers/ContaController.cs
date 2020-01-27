using FN.Store.Domain.Contracts.Repositories;
using FN.Store.UI.Infra.Helpers;
using FN.Store.UI.ViewModels.Conta.Login;
using System.Web.Mvc;
using System.Web.Security;

namespace FN.Store.UI.Controllers
{
	public class ContaController : Controller
    {
		private readonly IUsuarioRepository _usuarioRepository;


		public ContaController(IUsuarioRepository usuarioRepository)
		{
			_usuarioRepository = usuarioRepository;
		}

		[HttpGet]
		public ActionResult Login(string returnURL)
		{
			var model = new LoginVm() { ReturnUrl = returnURL };

			return View(model);
		}	

		[HttpPost]
		public ActionResult Login(LoginVm model)
		{

			var usuario = _usuarioRepository.Get(model.Email);
			if(usuario == null)
			{
				ModelState.AddModelError("Email", "O E-mail não foi encontrado");
			}
			else
			{
				if(usuario.Senha != model.Senha.Encrypt())
				{
					ModelState.AddModelError("Senha", "A senha e inválida");
				}
			}

			if(ModelState.IsValid)
			{

				FormsAuthentication.SetAuthCookie(model.Email, model.PermanecerLogado);



				if(!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
				{
					return Redirect(model.ReturnUrl);
				}

				return RedirectToAction("Index", "Home");
			}
			return View(model);
		}

		[HttpGet]
		public ActionResult LogOut()
		{
			FormsAuthentication.SignOut();
			return RedirectToAction("Login");
		}

		protected override void Dispose(bool disposing)
		{
			_usuarioRepository.Dispose();
		}






	}
}
