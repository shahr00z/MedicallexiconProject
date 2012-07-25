using System.Web.Mvc;

namespace MedicallexiconProject.Controllers
{
	public partial class AdministratorController : Controller
	{
		public virtual ActionResult Index()
		{
			return View();
		}

		public virtual ActionResult WordAdmin()
		{
			return PartialView();
		}

		public virtual ActionResult CategoryAdmin()
		{
			return PartialView();
		}

		public virtual ActionResult LanguageAdmin()
		{
			return PartialView();
		}
	}
}