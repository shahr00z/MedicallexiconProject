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
		private readonly IRelationshipBetweenWords _RelationshipBetweenWordsService;
		private readonly ICategoryService _categoryService;
		private readonly ILanguageService _languageService;
		private readonly IUnitOfWork _uow;
		private readonly IWordService _wordService;

		public WordController(IUnitOfWork uow, IWordService wordService, ICategoryService categoryService,
							  ILanguageService languageService, IRelationshipBetweenWords relationshipBetweenWordsService)
		{
			_wordService = wordService;
			_categoryService = categoryService;
			_languageService = languageService;
			_RelationshipBetweenWordsService = relationshipBetweenWordsService;
			_uow = uow;
		}

		public virtual ActionResult Index(string sort, string sortdir, int? page = 1)
		{
			IList<Word> list = _wordService.GetAll();
			IEnumerable<WordViewModel> model = GetWordViewModels(list);

			return View(model);
		}


		[HttpGet]
		public virtual ActionResult Create(int wordID = 0)
		{
			Word word = _wordService.GetByID(wordID);
			if (word != null)
			{
				var model = new WordViewModel
					{
						Categories = _categoryService.GetSelectList(),
						Languages = _languageService.GetSelectList(),
						WordRelatedID = word.ID,
						WordRelatedName = word.Name
					};
				return View(model);
			}
			else
			{
				var model = new WordViewModel
					{
						Categories = _categoryService.GetSelectList(),
						Languages = _languageService.GetSelectList(),
						WordRelatedID = 0
					};
				return View(model);
			}
		}

		[HttpPost]
		public virtual ActionResult Create(WordViewModel wordViewModel, int wordID = 0)
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
				if (wordID != 0)
				{
					var relationshipBetweenWords = new RelationshipBetweenWords { MainWord = word, RelatedWord = _wordService.GetByID(wordID) };
					_RelationshipBetweenWordsService.AddNew(relationshipBetweenWords);
					_uow.SaveChanges();
					return RedirectToAction(MVC.Word.ActionNames.Index);
				}
				_uow.SaveChanges();
				return RedirectToAction(MVC.Word.ActionNames.CreateRelationshipBetweenWord, new { id = word.ID });
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
			string imageFath = "/Uploads/Words/" + fileName;
			if (file.ContentLength > 0 && fileName != null)
			{
				string path = Path.Combine(Server.MapPath("~/Uploads/Words"), fileName);
				file.SaveAs(path);
			}

			return Content("<img src='" + imageFath + "' />");
		}

		public virtual ActionResult Details(int id)
		{
			WordViewModel wordViewModel = CreateWordViewModelByWordID(id);
			return View(wordViewModel);
		}

		public virtual ActionResult GetLanguage(int id)
		{
			IList<Language> language = _RelationshipBetweenWordsService.GetLanguage(id);
			var languageMapper = new LanguageMapper();
			IEnumerable<LanguageViewModel> model = languageMapper.ModelsViewModelsMapping(language);
			return PartialView("_WordLanguages", model);
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
			WordViewModel wordViewModel = CreateWordViewModelByWordID(id);
			return PartialView(viewName: MVC.Word.Views._WordInfo, model: wordViewModel);
		}

		public virtual ActionResult Search(string query)
		{
			return PartialView(MVC.Word.Views._WordSearch, _wordService.Search(query));
		}

		public virtual ActionResult QuickSearch(string term)
		{
			var word = _wordService.Search(term).
				Select(r => new { label = r.Name });

			return Json(word, JsonRequestBehavior.AllowGet);
		}

		[HttpPost]
		[OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
		public virtual ActionResult CheckWord(string name, int selectedLanguageID)
		{
			Word word = _wordService.GetWordByWordNameAndLanguageID(name, selectedLanguageID);
			return word.Name != null ? Json(false) : Json(true);
		}

		[HttpGet]
		public virtual ActionResult CreateRelationshipBetweenWord(int id)
		{
			WordViewModel wordViewModel = CreateWordViewModelByWordID(id);
			return View(wordViewModel);
		}

		[HttpPost]
		public virtual ActionResult CreateRelationshipBetweenWord(int mainWordID, int wordID)
		{
			return View();
		}

		private WordViewModel CreateWordViewModelByWordID(int id)
		{
			Word word = _wordService.GetByID(id);
			int relatedCount = _RelationshipBetweenWordsService.GetRelationCount(id);
			WordViewModel wordViewModel = GetWordViewModel(word);
			wordViewModel.RelatedCount = relatedCount;
			return wordViewModel;
		}

		private static WordViewModel GetWordViewModel(Word word)
		{
			var wordMapper = new WordMapper();
			WordViewModel wordViewModel = wordMapper.ModelViewModelMapping(word);
			return wordViewModel;
		}

		private static IEnumerable<WordViewModel> GetWordViewModels(IEnumerable<Word> list)
		{
			var wordMapper = new WordMapper();
			IEnumerable<WordViewModel> WordViewModels = wordMapper.ModelsViewModelsMapping(list);
			return WordViewModels;
		}

		public virtual ActionResult GetWords(string category, string language)
		{
			IEnumerable<Word> words;
			IEnumerable<WordViewModel> wordViewModels;
			if ((!string.IsNullOrEmpty(category) && !string.IsNullOrEmpty(language)))
			{
				words = _wordService.GetWordsByLanguageAndCategory(category, language);
				wordViewModels = GetWordViewModels(words);
				return View("WordList", wordViewModels);
			}
			if (!(string.IsNullOrEmpty(category)))
			{
				words = _wordService.GetAllWordByCategory(category);
				wordViewModels = GetWordViewModels(words);
				return View("WordList", wordViewModels);
			}
			if (!(string.IsNullOrEmpty(language)))
			{
				words = _wordService.GetAllWordByLanguage(language);
				wordViewModels = GetWordViewModels(words);
				return View("WordList", wordViewModels);
			}
			words = _wordService.GetAll();
			wordViewModels = GetWordViewModels(words);
			return View("WordList", wordViewModels);
		}
	}
}