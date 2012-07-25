using DomainClasses.Models;
using MedicallexiconProject.Controllers;
using MedicallexiconProject.ViewModel;
using NUnit.Framework;
using System.Web.Mvc;
namespace MedicallexiconProject.Test
{
	[TestFixture]
	public class LanguageControllerTest
	{
		[Test]
		public void Should_Add_LanguageViewModel()
		{
			var lanuageViewModel = new LanguageViewModel();
			var redirectToRouteResult = (RedirectToRouteResult)new LanguageController().Create(lanuageViewModel);
		
		}
	}
}
