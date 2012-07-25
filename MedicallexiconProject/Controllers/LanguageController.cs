using System.Web.Mvc;
using AutoMapper;
using DataLayer.Context;
using DomainClasses.Models;
using MedicallexiconProject.ViewModel;
using ServiceLayer.Interfaces;

namespace MedicallexiconProject.Controllers
{
	public partial class LanguageController : Controller
	{
		private readonly ILanguageService _languagService;
		private readonly IUnitOfWork _uow;

		public LanguageController(IUnitOfWork uow, ILanguageService languagService)
		{
			_languagService = languagService;
			_uow = uow;
		}

		public LanguageController()
		{
		}

		public virtual ActionResult Index()
		{
			return View(_languagService.GetAll());
		}

		public virtual ActionResult Create()
		{
			var languageViewModel = new LanguageViewModel();
			return View(languageViewModel);
		}

		[HttpPost]
		public virtual ActionResult Create(LanguageViewModel languageViewModel)
		{
			Mapper.CreateMap<LanguageViewModel, Language>();

			var language = new Language();
			Mapper.Map(languageViewModel, language);

			if (ModelState.IsValid)
			{
				_languagService.AddNew(language);
				_uow.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(languageViewModel);
		}

		//public ActionResult Edit(int id = 0)
		//{
		//    Language language = db.Language.Find(id);
		//    if (language == null)
		//    {
		//        return HttpNotFound();
		//    }
		//    return View(language);
		//}

		//
		// POST: /Language/Edit/5

		//[HttpPost]
		//public ActionResult Edit(Language language)
		//{
		//    if (ModelState.IsValid)
		//    {
		//        db.Entry(language).State = EntityState.Modified;
		//        db.SaveChanges();
		//        return RedirectToAction("Index");
		//    }
		//    return View(language);
		//}

		////
		//// GET: /Language/Delete/5

		public virtual ActionResult Delete(int id = 0)
		{
			Language language = _languagService.GetByID(id);
			if (language == null)
			{
				return HttpNotFound();
			}
			return PartialView(language);
		}

		//
		// POST: /Language/Delete/5

		[HttpPost, ActionName("Delete")]
		public virtual ActionResult DeleteConfirmed(int id)
		{
			return RedirectToAction("Index");
		}
	}
}