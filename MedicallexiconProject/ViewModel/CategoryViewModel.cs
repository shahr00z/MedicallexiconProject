using System.Collections.Generic;
using DomainClasses.Models;

namespace MedicallexiconProject.ViewModel
{
	public class CategoryViewModel
	{
		public string Name { get; set; }
		public IList<Word> Words { set; get; }
	}
}