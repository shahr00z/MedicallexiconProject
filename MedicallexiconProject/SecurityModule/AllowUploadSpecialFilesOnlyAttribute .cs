using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;
namespace MedicallexiconProject.SecurityModule
{
	public class AllowUploadSpecialFilesOnlyAttribute : ActionFilterAttribute
	{
		private readonly string _extensionsWhiteList;
		private readonly List<string> _toFilter = new List<string>();

		public AllowUploadSpecialFilesOnlyAttribute(string extensionsWhiteList)
		{
			if (string.IsNullOrWhiteSpace(extensionsWhiteList))
				throw new ArgumentNullException("extensionsWhiteList");
			_extensionsWhiteList = extensionsWhiteList;
			string[] extensions = extensionsWhiteList.Split(',');
			foreach (string extension in extensions.Where(ext => !string.IsNullOrWhiteSpace(ext)))
			{
				_toFilter.Add(extension.ToLowerInvariant().Trim());
			}
		}

		private bool canUpload(string fileName)
		{
			if (string.IsNullOrWhiteSpace(fileName.ToLowerInvariant())) return (false);

			string ext = Path.GetExtension(fileName.ToLowerInvariant());
			return _toFilter.Contains(ext);
		}

		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			var files = filterContext.HttpContext.Request.Files;
			foreach (string file in files)
			{
				var postedFile = files[file];

				if (postedFile == null || postedFile.ContentLength == 0) continue;

				if (!canUpload(postedFile.FileName) && !IsImageFile(postedFile))
					throw new InvalidOperationException(
						string.Format("You are not allowed to upload {0} file. Please upload only these files: {1}.",
									  Path.GetFileName(postedFile.FileName),
									  _extensionsWhiteList));
			}

			base.OnActionExecuting(filterContext);
		}
		private bool IsImageFile(HttpPostedFileBase photoFile)
		{
			using (var img = Image.FromStream(photoFile.InputStream))
			{
				return img.Width > 0;
			}
		}
	}

}