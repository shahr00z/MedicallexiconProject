using System.ComponentModel.DataAnnotations.Schema;
using DomainClasses.Classes;

namespace DomainClasses.Models
{
	public class Picture : BaseFieldsTables
	{
		public string Address { get; set; }
		public string Alt { get; set; }
		public string Tags { get; set; }

		[ForeignKey("WordID")]
		public virtual Word Words { get; set; }

		public int WordID { get; set; }
	}
}