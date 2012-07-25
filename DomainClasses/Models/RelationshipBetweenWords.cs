using System.ComponentModel.DataAnnotations.Schema;
using DomainClasses.Classes;

namespace DomainClasses.Models
{
	public class RelationshipBetweenWords : BaseFieldsTables
	{
		/// <summary>
		/// این فیلد جهت ایجاد رابطه بین 
		/// Word
		/// و
		/// RelationshipBetweenWords
		/// است.
		/// </summary>
		[InverseProperty("MainWords")]
		public virtual Word MainWord { get; set; }

		/// <summary>
		/// این فیلد جهت ایجاد رابطه بین 
		/// Word
		/// و
		/// RelationshipBetweenWords
		/// است.
		/// </summary>
		[InverseProperty("RelatedWords")]
		public virtual Word RelatedWord { get; set; }
	}
}