using System.Web.Mvc;

namespace MedicallexiconProject.Controllers
{
	public partial class HomeController : Controller
	{
		public virtual ActionResult Index()
		{
			ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

			return View();
		}

		public virtual ActionResult About()
		{
			return View();
		}

		public virtual ActionResult Contact()
		{
			return View();
		}
	}
}