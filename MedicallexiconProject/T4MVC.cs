﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static class MVC {
    public static MedicallexiconProject.Controllers.AccountController Account = new MedicallexiconProject.Controllers.T4MVC_AccountController();
    public static MedicallexiconProject.Controllers.AdministratorController Administrator = new MedicallexiconProject.Controllers.T4MVC_AdministratorController();
    public static MedicallexiconProject.Controllers.CategoryController Category = new MedicallexiconProject.Controllers.T4MVC_CategoryController();
    public static MedicallexiconProject.Controllers.HomeController Home = new MedicallexiconProject.Controllers.T4MVC_HomeController();
    public static MedicallexiconProject.Controllers.LanguageController Language = new MedicallexiconProject.Controllers.T4MVC_LanguageController();
    public static MedicallexiconProject.Controllers.WordController Word = new MedicallexiconProject.Controllers.T4MVC_WordController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC {
}

   
namespace System.Web.Mvc {
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class T4Extensions {
        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result) {
            return htmlHelper.ActionLink(linkText, result, null, null, null, null);
        }

        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result, object htmlAttributes, string protocol = null, string hostName = null, string fragment = null) {
            return htmlHelper.RouteLink(linkText, null, protocol ?? result.GetT4MVCResult().Protocol, hostName, fragment, result.GetRouteValueDictionary(), HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcHtmlString ActionLink(this HtmlHelper htmlHelper, string linkText, ActionResult result, IDictionary<string, object> htmlAttributes, string protocol = null, string hostName = null, string fragment = null) {
            return htmlHelper.RouteLink(linkText, null, protocol ?? result.GetT4MVCResult().Protocol, hostName, fragment, result.GetRouteValueDictionary(), htmlAttributes);
        }

        public static MvcForm BeginForm(this HtmlHelper htmlHelper, ActionResult result) {
            return htmlHelper.BeginForm(result, FormMethod.Post);
        }

        public static MvcForm BeginForm(this HtmlHelper htmlHelper, ActionResult result, FormMethod formMethod) {
            return htmlHelper.BeginForm(result, formMethod, null);
        }

        public static MvcForm BeginForm(this HtmlHelper htmlHelper, ActionResult result, FormMethod formMethod, object htmlAttributes) {
            return BeginForm(htmlHelper, result, formMethod, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcForm BeginForm(this HtmlHelper htmlHelper, ActionResult result, FormMethod formMethod, IDictionary<string, object> htmlAttributes) {
            var callInfo = result.GetT4MVCResult();
            return htmlHelper.BeginForm(callInfo.Action, callInfo.Controller, callInfo.RouteValueDictionary, formMethod, htmlAttributes);
        }

        public static void RenderAction(this HtmlHelper htmlHelper, ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            htmlHelper.RenderAction(callInfo.Action, callInfo.Controller, callInfo.RouteValueDictionary);
        }

        public static MvcHtmlString Action(this HtmlHelper htmlHelper, ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return htmlHelper.Action(callInfo.Action, callInfo.Controller, callInfo.RouteValueDictionary);
        }

        public static string Action(this UrlHelper urlHelper, ActionResult result) {
            return urlHelper.Action(result, null, null);
        }

        public static string Action(this UrlHelper urlHelper, ActionResult result, string protocol = null, string hostName = null) {
            return urlHelper.RouteUrl(null, result.GetRouteValueDictionary(), protocol ?? result.GetT4MVCResult().Protocol, hostName);
        }

        public static string ActionAbsolute(this UrlHelper urlHelper, ActionResult result) {
            return string.Format("{0}{1}",urlHelper.RequestContext.HttpContext.Request.Url.GetLeftPart(UriPartial.Authority),
                urlHelper.RouteUrl(result.GetRouteValueDictionary()));
        }

        public static MvcHtmlString ActionLink(this AjaxHelper ajaxHelper, string linkText, ActionResult result, AjaxOptions ajaxOptions) {
            return ajaxHelper.RouteLink(linkText, result.GetRouteValueDictionary(), ajaxOptions);
        }

        public static MvcHtmlString ActionLink(this AjaxHelper ajaxHelper, string linkText, ActionResult result, AjaxOptions ajaxOptions, object htmlAttributes) {
            return ajaxHelper.RouteLink(linkText, result.GetRouteValueDictionary(), ajaxOptions, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcHtmlString ActionLink(this AjaxHelper ajaxHelper, string linkText, ActionResult result, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes) {
            return ajaxHelper.RouteLink(linkText, result.GetRouteValueDictionary(), ajaxOptions, htmlAttributes);
        }

        public static MvcForm BeginForm(this AjaxHelper ajaxHelper, ActionResult result, AjaxOptions ajaxOptions) {
            return ajaxHelper.BeginForm(result, ajaxOptions, null);
        }

        public static MvcForm BeginForm(this AjaxHelper ajaxHelper, ActionResult result, AjaxOptions ajaxOptions, object htmlAttributes) {
            return BeginForm(ajaxHelper, result, ajaxOptions, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcForm BeginForm(this AjaxHelper ajaxHelper, ActionResult result, AjaxOptions ajaxOptions, IDictionary<string, object> htmlAttributes) {
            var callInfo = result.GetT4MVCResult();
            return ajaxHelper.BeginForm(callInfo.Action, callInfo.Controller, callInfo.RouteValueDictionary, ajaxOptions, htmlAttributes);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result) {
            return MapRoute(routes, name, url, result, null /*namespaces*/);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults) {
            return MapRoute(routes, name, url, result, defaults, null /*constraints*/, null /*namespaces*/);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, string[] namespaces) {
            return MapRoute(routes, name, url, result, null /*defaults*/, namespaces);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults, object constraints) {
            return MapRoute(routes, name, url, result, defaults, constraints, null /*namespaces*/);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults, string[] namespaces) {
            return MapRoute(routes, name, url, result, defaults, null /*constraints*/, namespaces);
        }

        public static Route MapRoute(this RouteCollection routes, string name, string url, ActionResult result, object defaults, object constraints, string[] namespaces) {
            // Create and add the route
            var route = CreateRoute(url, result, defaults, constraints, namespaces);
            routes.Add(name, route);
            return route;
        }

        // Note: can't name the AreaRegistrationContext methods 'MapRoute', as that conflicts with the existing methods
        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result) {
            return MapRouteArea(context, name, url, result, null /*namespaces*/);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults) {
            return MapRouteArea(context, name, url, result, defaults, null /*constraints*/, null /*namespaces*/);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, string[] namespaces) {
            return MapRouteArea(context, name, url, result, null /*defaults*/, namespaces);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults, object constraints) {
            return MapRouteArea(context, name, url, result, defaults, constraints, null /*namespaces*/);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults, string[] namespaces) {
            return MapRouteArea(context, name, url, result, defaults, null /*constraints*/, namespaces);
        }

        public static Route MapRouteArea(this AreaRegistrationContext context, string name, string url, ActionResult result, object defaults, object constraints, string[] namespaces) {
            // Create and add the route
            if ((namespaces == null) && (context.Namespaces != null)) {
                 namespaces = context.Namespaces.ToArray();
            }
            var route = CreateRoute(url, result, defaults, constraints, namespaces);
            context.Routes.Add(name, route);
            route.DataTokens["area"] = context.AreaName;
            bool useNamespaceFallback = (namespaces == null) || (namespaces.Length == 0);
            route.DataTokens["UseNamespaceFallback"] = useNamespaceFallback;
            return route;
        }

        private static Route CreateRoute(string url, ActionResult result, object defaults, object constraints, string[] namespaces) {
            // Start by adding the default values from the anonymous object (if any)
            var routeValues = new RouteValueDictionary(defaults);

            // Then add the Controller/Action names and the parameters from the call
            foreach (var pair in result.GetRouteValueDictionary()) {
                routeValues.Add(pair.Key, pair.Value);
            }

            var routeConstraints = new RouteValueDictionary(constraints);

            // Create and add the route
            var route = new Route(url, routeValues, routeConstraints, new MvcRouteHandler());

            route.DataTokens = new RouteValueDictionary();

            if (namespaces != null && namespaces.Length > 0) {
                route.DataTokens["Namespaces"] = namespaces;
            }

            return route;
        }

        public static IT4MVCActionResult GetT4MVCResult(this ActionResult result) {
            var t4MVCResult = result as IT4MVCActionResult;
            if (t4MVCResult == null) {
                throw new InvalidOperationException("T4MVC was called incorrectly. You may need to force it to regenerate by right clicking on T4MVC.tt and choosing Run Custom Tool");
            }
            return t4MVCResult;
        }

        public static RouteValueDictionary GetRouteValueDictionary(this ActionResult result) {
            return result.GetT4MVCResult().RouteValueDictionary;
        }

        public static ActionResult AddRouteValues(this ActionResult result, object routeValues) {
            return result.AddRouteValues(new RouteValueDictionary(routeValues));
        }

        public static ActionResult AddRouteValues(this ActionResult result, RouteValueDictionary routeValues) {
            RouteValueDictionary currentRouteValues = result.GetRouteValueDictionary();

            // Add all the extra values
            foreach (var pair in routeValues) {
                currentRouteValues.Add(pair.Key, pair.Value);
            }

            return result;
        }

        public static ActionResult AddRouteValues(this ActionResult result, System.Collections.Specialized.NameValueCollection nameValueCollection) {
            // Copy all the values from the NameValueCollection into the route dictionary
            nameValueCollection.CopyTo(result.GetRouteValueDictionary());
            return result;
        }

        public static ActionResult AddRouteValue(this ActionResult result, string name, object value) {
            RouteValueDictionary routeValues = result.GetRouteValueDictionary();
            routeValues.Add(name, value);
            return result;
        }
        
        public static void InitMVCT4Result(this IT4MVCActionResult result, string area, string controller, string action, string protocol = null) {
            result.Controller = controller;
            result.Action = action;
            result.Protocol = T4MVCHelpers.IsProduction() ? protocol : null;
            result.RouteValueDictionary = new RouteValueDictionary();
            result.RouteValueDictionary.Add("Area", area ?? "");
            result.RouteValueDictionary.Add("Controller", controller);
            result.RouteValueDictionary.Add("Action", action);
        }

        public static bool FileExists(string virtualPath) {
            if (!HostingEnvironment.IsHosted) return false;
            string filePath = HostingEnvironment.MapPath(virtualPath);
            return System.IO.File.Exists(filePath);
        }

        static DateTime CenturyBegin=new DateTime(2001,1,1);
        public static string TimestampString(string virtualPath) {
            if (!HostingEnvironment.IsHosted) return string.Empty;
            string filePath = HostingEnvironment.MapPath(virtualPath);
            return Convert.ToString((System.IO.File.GetLastWriteTimeUtc(filePath).Ticks-CenturyBegin.Ticks)/1000000000,16);            
        }
    }
}



namespace T4MVC {
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}


  

   
[GeneratedCode("T4MVC", "2.0")]   
public interface IT4MVCActionResult {   
    string Action { get; set; }   
    string Controller { get; set; }   
    RouteValueDictionary RouteValueDictionary { get; set; } 
    string Protocol {get; set; }  
}   
  

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public class T4MVC_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult {
    public T4MVC_ActionResult(string area, string controller, string action, string protocol = null): base()  {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public class T4MVC_JsonResult : System.Web.Mvc.JsonResult, IT4MVCActionResult {
    public T4MVC_JsonResult(string area, string controller, string action, string protocol = null): base()  {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links {
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string _references_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/_references.min.js") ? Url("_references.min.js") : Url("_references.js");
                      
        public static readonly string AjaxLogin_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/AjaxLogin.min.js") ? Url("AjaxLogin.min.js") : Url("AjaxLogin.js");
                      
        public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
                      
        public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
        public static readonly string Dictonary_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Dictonary.min.js") ? Url("Dictonary.min.js") : Url("Dictonary.js");
                      
        public static readonly string jquery_1_7_2_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.7.2-vsdoc.min.js") ? Url("jquery-1.7.2-vsdoc.min.js") : Url("jquery-1.7.2-vsdoc.js");
                      
        public static readonly string jquery_1_7_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.7.2.min.js") ? Url("jquery-1.7.2.min.js") : Url("jquery-1.7.2.js");
                      
        public static readonly string jquery_1_7_2_min_js = Url("jquery-1.7.2.min.js");
        public static readonly string jquery_ui_1_8_11_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui-1.8.11.min.js") ? Url("jquery-ui-1.8.11.min.js") : Url("jquery-ui-1.8.11.js");
                      
        public static readonly string jquery_ui_1_8_11_min_js = Url("jquery-ui-1.8.11.min.js");
        public static readonly string jQuery_tmpl_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jQuery.tmpl.min.js") ? Url("jQuery.tmpl.min.js") : Url("jQuery.tmpl.js");
                      
        public static readonly string jQuery_tmpl_min_js = Url("jQuery.tmpl.min.js");
        public static readonly string jquery_unobtrusive_ajax_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.unobtrusive-ajax.min.js") ? Url("jquery.unobtrusive-ajax.min.js") : Url("jquery.unobtrusive-ajax.js");
                      
        public static readonly string jquery_unobtrusive_ajax_min_js = Url("jquery.unobtrusive-ajax.min.js");
        public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
                      
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
                      
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
                      
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
        public static readonly string knockout_2_0_0_debug_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/knockout-2.0.0.debug.min.js") ? Url("knockout-2.0.0.debug.min.js") : Url("knockout-2.0.0.debug.js");
                      
        public static readonly string knockout_2_0_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/knockout-2.0.0.min.js") ? Url("knockout-2.0.0.min.js") : Url("knockout-2.0.0.js");
                      
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Mobile {
            private const string URLPATH = "~/Scripts/Mobile";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string jquery_mobile_1_1_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.mobile-1.1.0.min.js") ? Url("jquery.mobile-1.1.0.min.js") : Url("jquery.mobile-1.1.0.js");
                          
            public static readonly string jquery_mobile_1_1_0_min_js = Url("jquery.mobile-1.1.0.min.js");
        }
    
        public static readonly string modernizr_2_0_6_development_only_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/modernizr-2.0.6-development-only.min.js") ? Url("modernizr-2.0.6-development-only.min.js") : Url("modernizr-2.0.6-development-only.js");
                      
        public static readonly string native_history_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/native.history.min.js") ? Url("native.history.min.js") : Url("native.history.js");
                      
        public static readonly string nav_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/nav.min.js") ? Url("nav.min.js") : Url("nav.js");
                      
        public static readonly string nav_min_js = Url("nav.min.js");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Uploadify {
            private const string URLPATH = "~/Scripts/Uploadify";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string cancel_png = Url("cancel.png");
            public static readonly string check_php = Url("check.php");
            public static readonly string expressInstall_swf = Url("expressInstall.swf");
            public static readonly string jquery_1_4_2_min_js = Url("jquery-1.4.2.min.js");
            public static readonly string jquery_uploadify_v2_1_4_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.uploadify.v2.1.4.min.js") ? Url("jquery.uploadify.v2.1.4.min.js") : Url("jquery.uploadify.v2.1.4.js");
                          
            public static readonly string jquery_uploadify_v2_1_4_min_js = Url("jquery.uploadify.v2.1.4.min.js");
            public static readonly string swfobject_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/swfobject.min.js") ? Url("swfobject.min.js") : Url("swfobject.js");
                          
            public static readonly string uploadify_allglyphs_swf = Url("uploadify.allglyphs.swf");
            public static readonly string uploadify_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/uploadify.min.css") ? Url("uploadify.min.css") : Url("uploadify.css");
                 
            public static readonly string uploadify_fla = Url("uploadify.fla");
            public static readonly string uploadify_php = Url("uploadify.php");
            public static readonly string uploadify_swf = Url("uploadify.swf");
        }
    
        public static readonly string upshot_compat_knockout_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/upshot.compat.knockout.min.js") ? Url("upshot.compat.knockout.min.js") : Url("upshot.compat.knockout.js");
                      
        public static readonly string upshot_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/upshot.min.js") ? Url("upshot.min.js") : Url("upshot.js");
                      
        public static readonly string upshot_knockout_extensions_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/upshot.knockout.extensions.min.js") ? Url("upshot.knockout.extensions.min.js") : Url("upshot.knockout.extensions.js");
                      
        public static readonly string upshot_min_js = Url("upshot.min.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class bootstrap {
            private const string URLPATH = "~/Content/bootstrap";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string bootstrap_responsive_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap-responsive.min.css") ? Url("bootstrap-responsive.min.css") : Url("bootstrap-responsive.css");
                 
            public static readonly string bootstrap_responsive_min_css = Url("bootstrap-responsive.min.css");
            public static readonly string bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.css") ? Url("bootstrap.min.css") : Url("bootstrap.css");
                 
            public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class images {
            private const string URLPATH = "~/Content/images";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string ajax_loader_gif = Url("ajax-loader.gif");
            public static readonly string ajax_loader_png = Url("ajax-loader.png");
            public static readonly string icons_18_black_png = Url("icons-18-black.png");
            public static readonly string icons_18_white_png = Url("icons-18-white.png");
            public static readonly string icons_36_black_png = Url("icons-36-black.png");
            public static readonly string icons_36_white_png = Url("icons-36-white.png");
        }
    
        public static readonly string Site_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Site.min.css") ? Url("Site.min.css") : Url("Site.css");
             
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class themes {
            private const string URLPATH = "~/Content/themes";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class @base {
                private const string URLPATH = "~/Content/themes/base";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class images {
                    private const string URLPATH = "~/Content/themes/base/images";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string images_png = Url("images.png");
                    public static readonly string lines_png = Url("lines.png");
                    public static readonly string ui_bg_diagonals_thick_18_b81900_40x40_png = Url("ui-bg_diagonals-thick_18_b81900_40x40.png");
                    public static readonly string ui_bg_diagonals_thick_20_666666_40x40_png = Url("ui-bg_diagonals-thick_20_666666_40x40.png");
                    public static readonly string ui_bg_flat_0_aaaaaa_40x100_png = Url("ui-bg_flat_0_aaaaaa_40x100.png");
                    public static readonly string ui_bg_flat_10_000000_40x100_png = Url("ui-bg_flat_10_000000_40x100.png");
                    public static readonly string ui_bg_flat_75_ffffff_40x100_png = Url("ui-bg_flat_75_ffffff_40x100.png");
                    public static readonly string ui_bg_glass_100_f6f6f6_1x400_png = Url("ui-bg_glass_100_f6f6f6_1x400.png");
                    public static readonly string ui_bg_glass_100_fdf5ce_1x400_png = Url("ui-bg_glass_100_fdf5ce_1x400.png");
                    public static readonly string ui_bg_glass_55_fbf9ee_1x400_png = Url("ui-bg_glass_55_fbf9ee_1x400.png");
                    public static readonly string ui_bg_glass_65_ffffff_1x400_png = Url("ui-bg_glass_65_ffffff_1x400.png");
                    public static readonly string ui_bg_glass_75_dadada_1x400_png = Url("ui-bg_glass_75_dadada_1x400.png");
                    public static readonly string ui_bg_glass_75_e6e6e6_1x400_png = Url("ui-bg_glass_75_e6e6e6_1x400.png");
                    public static readonly string ui_bg_glass_95_fef1ec_1x400_png = Url("ui-bg_glass_95_fef1ec_1x400.png");
                    public static readonly string ui_bg_gloss_wave_35_f6a828_500x100_png = Url("ui-bg_gloss-wave_35_f6a828_500x100.png");
                    public static readonly string ui_bg_highlight_soft_100_eeeeee_1x100_png = Url("ui-bg_highlight-soft_100_eeeeee_1x100.png");
                    public static readonly string ui_bg_highlight_soft_75_cccccc_1x100_png = Url("ui-bg_highlight-soft_75_cccccc_1x100.png");
                    public static readonly string ui_bg_highlight_soft_75_ffe45c_1x100_png = Url("ui-bg_highlight-soft_75_ffe45c_1x100.png");
                    public static readonly string ui_icons_222222_256x240_png = Url("ui-icons_222222_256x240.png");
                    public static readonly string ui_icons_228ef1_256x240_png = Url("ui-icons_228ef1_256x240.png");
                    public static readonly string ui_icons_2e83ff_256x240_png = Url("ui-icons_2e83ff_256x240.png");
                    public static readonly string ui_icons_454545_256x240_png = Url("ui-icons_454545_256x240.png");
                    public static readonly string ui_icons_494f5c_256x240_png = Url("ui-icons_494f5c_256x240.png");
                    public static readonly string ui_icons_666666_256x240_png = Url("ui-icons_666666_256x240.png");
                    public static readonly string ui_icons_888888_256x240_png = Url("ui-icons_888888_256x240.png");
                    public static readonly string ui_icons_cd0a0a_256x240_png = Url("ui-icons_cd0a0a_256x240.png");
                    public static readonly string ui_icons_ef8c08_256x240_png = Url("ui-icons_ef8c08_256x240.png");
                    public static readonly string ui_icons_ffd27a_256x240_png = Url("ui-icons_ffd27a_256x240.png");
                    public static readonly string ui_icons_ffffff_256x240_png = Url("ui-icons_ffffff_256x240.png");
                }
            
                public static readonly string jquery_ui_1_8_17_custom_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui-1.8.17.custom.min.css") ? Url("jquery-ui-1.8.17.custom.min.css") : Url("jquery-ui-1.8.17.custom.css");
                     
                public static readonly string jquery_ui_accordion_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.accordion.min.css") ? Url("jquery.ui.accordion.min.css") : Url("jquery.ui.accordion.css");
                     
                public static readonly string jquery_ui_all_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.all.min.css") ? Url("jquery.ui.all.min.css") : Url("jquery.ui.all.css");
                     
                public static readonly string jquery_ui_autocomplete_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.autocomplete.min.css") ? Url("jquery.ui.autocomplete.min.css") : Url("jquery.ui.autocomplete.css");
                     
                public static readonly string jquery_ui_base_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.base.min.css") ? Url("jquery.ui.base.min.css") : Url("jquery.ui.base.css");
                     
                public static readonly string jquery_ui_button_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.button.min.css") ? Url("jquery.ui.button.min.css") : Url("jquery.ui.button.css");
                     
                public static readonly string jquery_ui_core_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.core.min.css") ? Url("jquery.ui.core.min.css") : Url("jquery.ui.core.css");
                     
                public static readonly string jquery_ui_datepicker_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.datepicker.min.css") ? Url("jquery.ui.datepicker.min.css") : Url("jquery.ui.datepicker.css");
                     
                public static readonly string jquery_ui_dialog_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.dialog.min.css") ? Url("jquery.ui.dialog.min.css") : Url("jquery.ui.dialog.css");
                     
                public static readonly string jquery_ui_progressbar_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.progressbar.min.css") ? Url("jquery.ui.progressbar.min.css") : Url("jquery.ui.progressbar.css");
                     
                public static readonly string jquery_ui_resizable_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.resizable.min.css") ? Url("jquery.ui.resizable.min.css") : Url("jquery.ui.resizable.css");
                     
                public static readonly string jquery_ui_selectable_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.selectable.min.css") ? Url("jquery.ui.selectable.min.css") : Url("jquery.ui.selectable.css");
                     
                public static readonly string jquery_ui_slider_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.slider.min.css") ? Url("jquery.ui.slider.min.css") : Url("jquery.ui.slider.css");
                     
                public static readonly string jquery_ui_tabs_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.tabs.min.css") ? Url("jquery.ui.tabs.min.css") : Url("jquery.ui.tabs.css");
                     
                public static readonly string jquery_ui_theme_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.theme.min.css") ? Url("jquery.ui.theme.min.css") : Url("jquery.ui.theme.css");
                     
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Mobile {
                private const string URLPATH = "~/Content/themes/Mobile";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string jquery_mobile_1_1_0_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.mobile-1.1.0.min.css") ? Url("jquery.mobile-1.1.0.min.css") : Url("jquery.mobile-1.1.0.css");
                     
                public static readonly string jquery_mobile_1_1_0_min_css = Url("jquery.mobile-1.1.0.min.css");
                public static readonly string jquery_mobile_structure_1_1_0_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.mobile.structure-1.1.0.min.css") ? Url("jquery.mobile.structure-1.1.0.min.css") : Url("jquery.mobile.structure-1.1.0.css");
                     
                public static readonly string jquery_mobile_structure_1_1_0_min_css = Url("jquery.mobile.structure-1.1.0.min.css");
                public static readonly string jquery_mobile_theme_1_1_0_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.mobile.theme-1.1.0.min.css") ? Url("jquery.mobile.theme-1.1.0.min.css") : Url("jquery.mobile.theme-1.1.0.css");
                     
                public static readonly string jquery_mobile_theme_1_1_0_min_css = Url("jquery.mobile.theme-1.1.0.min.css");
            }
        
        }
    
    }

}

public static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;


    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591


