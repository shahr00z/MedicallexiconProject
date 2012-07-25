using System.Data.Entity.ModelConfiguration;
using DomainClasses.Models;

namespace DataLayer.Mapping
{
	/// <summary>
	/// این کلاس جهت مدیریت جدولی است که قرار است در دیتا بیس درست شود
	/// </summary>
	public class WordConfig : EntityTypeConfiguration<Word>
	{
		public WordConfig()
		{
			Property(x => x.Name).IsRequired();

			Property(x => x.RowVersion).IsRowVersion()
				.IsOptional();


			HasRequired(x => x.Category)
				.WithMany(x => x.Words)
				.WillCascadeOnDelete();

			
			HasRequired(x => x.Language)
				.WithMany(x => x.Words)
				.WillCascadeOnDelete();
			}

	}
}