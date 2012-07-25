using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using AutoMapper;
using DataLayer.Context;
using DomainClasses.Models;
using MedicallexiconProject.Classes.CustomMapper;
using MedicallexiconProject.SecurityModule;
using MedicallexiconProject.ViewModel;
using ServiceLayer.Interfaces;

namespace MedicallexiconProject.Controllers
{
	public partial class WordController : Controller
	{
		private readonly ICategoryService _categoryService;
		private readonly ILanguageService _languageService;
		private readonly IUnitOfWork _uow;
		private readonly IWordService _wordService;

		public WordController(IUnitOfWork uow, IWordService wordService, ICategoryService categoryService,
		                      ILanguageService languageService)
		{
			_wordService = wordService;
			_categoryService = categoryService;
			_languageService = languageService;
			_uow = uow;
		}

		public virtual ActionResult Index(string sort, string sortdir, int? page = 1)
		{
			IList<Word> list = _wordService.GetAll();
			var wordMapper = new WordMapper();
			IEnumerable<WordViewModel> model = wordMapper.ModelsViewModelsMapping(list);

			return View(model);
		}

		[HttpGet]
		public virtual ActionResult Create()
		{
			var model = new WordViewModel
				{
					Categories = _categoryService.GetSelectList(),
					Languages = _languageService.GetSelectList()
				};

			return View(model);
		}

		[HttpPost]
		public virtual ActionResult Create(WordViewModel wordViewModel)
		{
			var word = new Word();
			Mapper.Map(wordViewModel, word);

			Category category = _categoryService.GetByID(wordViewModel.SelectedCategoryID);
			word.Category = category;

			Language Language = _languageService.GetByID(wordViewModel.SelectedLanguageID);
			word.Language = Language;

			if (ModelState.IsValid)
			{
				_wordService.AddNew(word);
				_uow.SaveChanges();
				return RedirectToAction(MVC.Word.UploadWordsPicture().AddRouteValue("ID", word.ID));
			}
			wordViewModel.Categories = _categoryService.GetSelectList();
			wordViewModel.Languages = _languageService.GetSelectList();
			return View(wordViewModel);
		}


		[HttpPost]
		[AllowUploadSpecialFilesOnly(".jpg,.gif,.png")]
		public virtual ActionResult UploadWordsPicture(HttpPostedFileBase file)
		{
			string fileName = Path.GetFileName(file.FileName);
			string imageFath = "../../Uploads/Words/"+fileName;
			if (file.ContentLength > 0 && fileName != null)
			{
				string path = Path.Combine(Server.MapPath("~/Uploads/Words"), fileName);
				file.SaveAs(path);
			}

			return Content("<img src='" + imageFath + "' />");
		}

		public virtual ActionResult Details(int id)
		{
			Word word = _wordService.GetByID(id);
			var wordMapper = new WordMapper();
			WordViewModel wordViewModel = wordMapper.ModelViewModelMapping(word);
			return View(wordViewModel);
		}

		[HttpPost]
		public virtual ActionResult Delete(int id)
		{
			_wordService.Delete(id);
			_uow.SaveChanges();
			return RedirectToAction(Index());
		}

		[HttpGet]
		public virtual ActionResult Edit(int id)
		{
			return (null);
		}

		[HttpPost]
		public virtual ActionResult WordInfo(int id)
		{
			Word word = _wordService.GetByID(id);
			var wordMapper = new WordMapper();
			WordViewModel wordViewModel = wordMapper.ModelViewModelMapping(word);
			return PartialView(viewName: MVC.Word.Views._WordInfo, model: wordViewModel);
		}

		public virtual ActionResult Search(string query)
		{
			return PartialView(MVC.Word.Views._WordSearch, _wordService.Search(query));
		}

		public virtual ActionResult QuickSearch(string term)
		{
			var word = _wordService.Search(term).
				Select(r => new {label = r.Name});

			return Json(word, JsonRequestBehavior.AllowGet);
		}

		[HttpPost]
		[OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
		public virtual ActionResult CheckWord(string name, int selectedLanguageID)
		{
			Word word = _wordService.GetWordByWordNameAndLanguageID(name, selectedLanguageID);
			return word.Name != null ? Json(false) : Json(true);
		}
	}
}