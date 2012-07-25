using System;
using System.Globalization;
using System.Web.Mvc;
using MedicallexiconProject.Classes;

namespace MedicallexiconProject.Binders
{
	public class PersianDateModelBinder : IModelBinder
	{
		#region IModelBinder Members

		public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
		{
			ValueProviderResult valueResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
			var modelState = new ModelState {Value = valueResult};
			object actualValue = null;
			try
			{
				string pdate = valueResult.AttemptedValue.ToResilientPersianDate();

				string[] parts = pdate.Split('/'); //ex. 1391/1/19  
				if (parts.Length != 3) return null;
				int year = int.Parse(parts[0]);
				int month = int.Parse(parts[1]);
				int day = int.Parse(parts[2]);
				actualValue = new DateTime(year, month, day, new PersianCalendar());
			}
			catch (FormatException e)
			{
				modelState.Errors.Add(e);
			}

			bindingContext.ModelState.Add(bindingContext.ModelName, modelState);
			return actualValue;
		}

		#endregion
	}
}