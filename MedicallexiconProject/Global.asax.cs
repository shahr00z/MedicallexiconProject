using System;
using System.Data.Entity;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using DataLayer.Context;
using DomainClasses.Models;
using MedicallexiconProject.Binders;
using MedicallexiconProject.Classes;
using MedicallexiconProject.ViewModel;
using ServiceLayer.Interfaces;
using ServiceLayer.Services;
using StructureMap;

namespace MedicallexiconProject
{
	public class MvcApplication : HttpApplication
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}

		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			routes.MapRoute(
				name: "Word",
				url: "{controller}/{action}/{id}/{Name}",
				defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional, name = UrlParameter.Optional});
			routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new {id = RouteParameter.Optional}
				);
		}

		protected void Application_Start()
		{
			ConfigurMapping();
			ModelBinders.Binders.Add(typeof (DateTime), new PersianDateModelBinder());
			BundleConfig.RegisterBundles(BundleTable.Bundles);
			BundleTable.Bundles.EnableBootstrapBundle();

			Database.SetInitializer<MedicallexiconContext>(null);
			//Database.SetInitializer(
			//	new MigrateDatabaseToLatestVersion<MedicallexiconContext, MedicallexiconContextConfiguration>());
			AreaRegistration.RegisterAllAreas();

			RegisterGlobalFilters(GlobalFilters.Filters);
			RegisterRoutes(RouteTable.Routes);

			initStructureMap();
		}

		private void ConfigurMapping()
		{
			Mapper.CreateMap<WordViewModel, Word>();
			Mapper.CreateMap<CategoryViewModel, Category>();
			Mapper.CreateMap<LanguageViewModel, Language>();
		}

		private void initStructureMap()
		{
			ObjectFactory.Initialize(x =>
				{
					x.For<IUnitOfWork>().HttpContextScoped().Use(() => new MedicallexiconContext());

					x.ForRequestedType<IWordService>().TheDefaultIsConcreteType<EfWordService>();

					x.ForRequestedType<ICategoryService>().TheDefaultIsConcreteType<EfCategoryService>();

					x.ForRequestedType<ILanguageService>().TheDefaultIsConcreteType<EfLanguageService>();

					x.ForRequestedType<IPictureService>().TheDefaultIsConcreteType<EfPictureService>();
					x.ForRequestedType<IRelationshipBetweenWords>().TheDefaultIsConcreteType<EfRelationshipBetweenWordsService>();
				});
			//Set current Controller factory as StructureMapControllerFactory  
			ControllerBuilder.Current.SetControllerFactory(new StructureMapControllerFactory());
		}


		protected void Application_EndRequest(object sender, EventArgs e)
		{
			ObjectFactory.ReleaseAndDisposeAllHttpScopedObjects();
		}
	}

	public class StructureMapControllerFactory : DefaultControllerFactory
	{
		protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
		{
			return ObjectFactory.GetInstance(controllerType) as Controller;
		}
	}

	public static class Css
	{
		public static void EnableBootstrapBundle(this BundleCollection bundles)
		{
			var bootstrapCss = new Bundle("~/Content/bootstrap/css", new CssMinify());
			bootstrapCss.Include("~/Content/bootstrap/bootstrap.css");
			bootstrapCss.Include("~/Content/bootstrap/bootstrap-responsive.css");

			bundles.Add(bootstrapCss);

			var bootstrapJs = new Bundle("~/Scripts/bootstrap/js", new JsMinify());
			bootstrapJs.Include("~/Scripts/jquery-1.7.2.min.js");
			bootstrapJs.Include("~/Scripts/jquery-ui-1.8.11.min.js");
			bootstrapJs.Include("~/Scripts/jQuery.tmpl.min.js");
			bootstrapJs.Include("~/Scripts/jquery.unobtrusive-ajax.min.js");
			bootstrapJs.Include("~/Scripts/bootstrap.js");

			bundles.Add(bootstrapJs);
		}
	}
}