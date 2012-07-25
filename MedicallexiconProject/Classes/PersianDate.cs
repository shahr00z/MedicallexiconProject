using System;
using System.Linq;

namespace MedicallexiconProject.Classes
{
	public static class ResilientDate
	{
		#region Fields (1)

		private static readonly string[] Separators = new[] {".", "/", "-"};

		#endregion Fields

		#region Methods (9)

		// Public Methods 
		/// <summary>
		/// supported formats ۹۰/۸/۱۴ & ۱۳۹۰/۸/۱۴ & ۹۰-۸-۱۴ & ۱۳۹۰-۸-۱۴
		/// </summary>
		/// <param name="persianDate"></param>
		/// <returns></returns>
		public static string ToResilientPersianDate(this string persianDate)
		{
			if (string.IsNullOrWhiteSpace(persianDate)) return string.Empty;


			string separator = Separators.FirstOrDefault(item => persianDate.Contains(item));
			if (separator == null) return string.Empty;

			string[] parts = persianDate.Split(new[] {separator}, StringSplitOptions.RemoveEmptyEntries);
			if (parts.Length != 3) return string.Empty;

			int? pYear = GetYear(parts[0]);
			if (!pYear.HasValue) return string.Empty;

			int? pMonth = GetMonth(parts[1]);
			if (!pMonth.HasValue) return string.Empty;

			int? pDay = GetDay(parts[2]);
			if (!pDay.HasValue) return string.Empty;

			return toString(pYear.Value, pMonth.Value, pDay.Value);
		}

		// Private Methods (7) 

		private static int? GetDay(string part)
		{
			Tuple<bool, int> day = part.ToNumber();
			if (!day.Item1) return null;
			int pDay = day.Item2;
			if (pDay == 0 || pDay > 31) return null;
			return pDay;
		}

		private static int? GetMonth(string part)
		{
			Tuple<bool, int> month = part.ToNumber();
			if (!month.Item1) return null;
			int pMonth = month.Item2;
			if (pMonth == 0 || pMonth > 12) return null;
			return pMonth;
		}

		private static int? GetYear(string part)
		{
			Tuple<bool, int> year = part.ToNumber();
			if (!year.Item1) return null;
			int pYear = year.Item2;
			if (part.Length == 2) pYear += 1300;
			return pYear;
		}

		private static Tuple<bool, int> ToNumber(this string data)
		{
			int number;
			bool result = int.TryParse(data, out number);
			return new Tuple<bool, int>(result, number);
		}

		private static string toString(int year, int month, int day)
		{
			return year + "/" + month + "/" + day;
		}

		#endregion Methods
	}
}