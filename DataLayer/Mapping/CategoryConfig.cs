using System.Data.Entity.ModelConfiguration;
using DomainClasses.Models;

namespace DataLayer.Mapping
{
	/// <summary>
	/// این کلاس جهت مدیریت جدولی است که قرار است در دیتا بیس درست شود
	/// </summary>
	public class CategoryConfig : EntityTypeConfiguration<Category>
	{
		public CategoryConfig()
		{
			Property(x => x.Name).IsRequired();
			Property(x => x.RowVersion).IsRowVersion()
				.IsOptional();

		}
	}
}