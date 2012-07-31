using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;

namespace MedicallexiconProject.ViewModel
{
	public class WordViewModel
	{
		public int ID { get; set; }

		public string Name { get; set; }


		public IList<SelectListItem> Categories { set; get; }

		[HiddenInput(DisplayValue = false)]
		public int SelectedCategoryID { set; get; }


		public IList<SelectListItem> Languages { set; get; }
		[HiddenInput(DisplayValue = false)]
		public int SelectedLanguageID { set; get; }
		public string LanguageName { get; set; }
		public string CategoryName { get; set; }
		public string Description { get; set; }
		[AllowHtml]
		public string Text { get; set; }
		public string WordRelatedName { get; set; }
		public int WordRelatedID { get; set; }
		public int RelatedCount { get; set; }
		public DateTime CreatedDate { get; set; }

		private HttpPostedFileBase Picture { get; set; }
	}
}