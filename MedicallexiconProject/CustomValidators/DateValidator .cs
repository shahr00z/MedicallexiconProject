using System.ComponentModel.DataAnnotations;

namespace MedicallexiconProject.CustomValidators
{
	public class DateValidator : ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			if (value == null) return false;


			return true;
		}
	}
}