using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using DomainClasses.Classes;

namespace DomainClasses.Models
{
	public class Word : BaseFieldsTables
	{
		public string Text { get; set; }

		[ForeignKey("CategoryID")]
		public virtual Category Category { get; set; }

		public int CategoryID { get; set; }

		[ForeignKey("LanguageID")]
		public virtual Language Language { get; set; }

		public int LanguageID { get; set; }

		public virtual ICollection<Picture> Pictures { get; set; }

		[InverseProperty("MainWord")]
		public virtual ICollection<RelationshipBetweenWords> MainWords { get; set; }

		[InverseProperty("RelatedWord")]
		public virtual ICollection<RelationshipBetweenWords> RelatedWords { get; set; }
	}
}