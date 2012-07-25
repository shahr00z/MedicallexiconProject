using System.Text.RegularExpressions;

namespace MedicallexiconProject.Helpers
{
	public static class StringHelpers
	{
		public static string ToSeoUrl(this string url)
		{
			// make the url lowercase
			string encodedUrl = (url ?? "").ToLower();

			// replace & with and
			encodedUrl = Regex.Replace(encodedUrl, @"\&+", "and");

			// remove characters
			encodedUrl = encodedUrl.Replace("'", "");

			// remove invalid characters
			encodedUrl = Regex.Replace(encodedUrl, @"[^a-z0-9-\u0600-\u06FF]", "-");

			// remove duplicates
			encodedUrl = Regex.Replace(encodedUrl, @"-+", "-");

			// trim leading & trailing characters
			encodedUrl = encodedUrl.Trim('-');

			return encodedUrl;
		}
	}
}