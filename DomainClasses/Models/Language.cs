using System.Collections.Generic;
using DomainClasses.Classes;

namespace DomainClasses.Models
{
	public class Language : BaseFieldsTables
	{
		public virtual ICollection<Word> Words { get; set; }
	}
}