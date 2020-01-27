using FN.Store.UI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace FN.Store.Testes.UI.Controllers
{
	[TestClass , TestCategory("Controllers/HomeController")]
    public class HomeControllerTest
    {
        
		[TestMethod]
		public void OMetodoIndexDeveRetornarUmaView()
		{
			//arrange
			var homecontroller = new HomeController();



			//act
			var result = homecontroller.Index();

			//assert
			Assert.AreEqual(typeof(ViewResult), result.GetType());


		}
    }
}
