using System.Data.Entity.Migrations;

namespace DataLayer.Context
{
	/// <summary>
	///جهت ایجاد پیکربندی سفارشی
	/// </summary>
	public class MedicallexiconContextConfiguration : DbMigrationsConfiguration<MedicallexiconContext>
	{
		public MedicallexiconContextConfiguration()
		{
			AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = true;
		}
	}
}