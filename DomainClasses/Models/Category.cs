using System.Collections.Generic;
using System.Web.Mvc;
using DomainClasses.Classes;

namespace DomainClasses.Models
{
	public class Category : BaseFieldsTables
	{
		public virtual ICollection<Word> Words { get; set; }
	}
}