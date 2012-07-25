using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;

namespace MedicallexiconProject.ViewModel
{
	public class WordViewModel
	{
		public int ID { get; set; }
		//[Remote(action: "CheckWord",
		//	controller: "Word",
		//	HttpMethod = "POST",
		//	AdditionalFields = "Languages",
		//	ErrorMessage = "این کلمه در بانک اطلاعاتی سیستم موجود است.")]
		[DisplayName("نام کلمه")]
		[Required(ErrorMessage = "وارد کردن نام کلمه اجباری است")]
		public string Name { get; set; }


		public IList<SelectListItem> Categories { set; get; }

		[Required(ErrorMessage = "انتخاب دسته بندی اجباریست ")]
		[DisplayName("دسته بندی")]
		[HiddenInput(DisplayValue = false)]
		public int SelectedCategoryID { set; get; }


		public IList<SelectListItem> Languages { set; get; }


		[DisplayName("زبان")]
		[Required(ErrorMessage = "انتخاب زبان اجباریست ")]
		[HiddenInput(DisplayValue = false)]
		public int SelectedLanguageID { set; get; }


		public string LanguageName { get; set; }
		public string CategoryName { get; set; }
		public string Description { get; set; }
		public string Text { get; set; }

		public DateTime CreatedDate { get; set; }

		private HttpPostedFileBase Picture { get; set; }
	}
}