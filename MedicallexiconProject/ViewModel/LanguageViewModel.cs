using System.Collections.Generic;
using System.ComponentModel;
using DomainClasses.Models;

namespace MedicallexiconProject.ViewModel
{
	public class LanguageViewModel
	{
		[DisplayName("زبان")]
		public string Name { get; set; }

		public IList<Word> Words { set; get; }
	}
}