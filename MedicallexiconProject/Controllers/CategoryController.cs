using System.Collections.Generic;
using System.Web.Mvc;
using DataLayer.Context;
using DomainClasses.Models;
using MedicallexiconProject.Classes.CustomMapper;
using MedicallexiconProject.ViewModel;
using ServiceLayer.Interfaces;

namespace MedicallexiconProject.Controllers
{
	public partial class CategoryController : Controller
	{
		private readonly ICategoryService _categoryService;
		private readonly IUnitOfWork _uow;

		public CategoryController(IUnitOfWork uow, ICategoryService categoryService)
		{
			_uow = uow;
			_categoryService = categoryService;
		}

		public virtual ActionResult Index()
		{
			var categoryMapper = new CategoryMapper();

			IList<Category> category = _categoryService.GetAll();
			IEnumerable<CategoryViewModel> model = categoryMapper.ModelsViewModelsMapping(category);

			return View(model);
		}

	}
}