using System.Web.Mvc;
using DataLayer.Context;
using MedicallexiconProject.ViewModel;
using ServiceLayer.Interfaces;

namespace MedicallexiconProject.Controllers
{
	public partial class HomeController : Controller
	{
		private readonly ILanguageService _languageService;
		private readonly IUnitOfWork _uow;
		private readonly IWordService _wordService;

		public HomeController(IUnitOfWork uow, ILanguageService languageService, IWordService wordService)
		{
			_uow = uow;
			_languageService = languageService;
			_wordService = wordService;
		}

		public virtual ActionResult Index()
		{
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

		public virtual ActionResult GetEntityCount()
		{
			var countViewModel = new CountViewModel();

			int languageCount = _languageService.GetCount();
			int wordCount = _wordService.GetCount();
			countViewModel.LanguageCount = languageCount;
			countViewModel.WordCount = wordCount;

			return PartialView(MVC.Home.Views._GetEntityCount,countViewModel);
		}
	}
}