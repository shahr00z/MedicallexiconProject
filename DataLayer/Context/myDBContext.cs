using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;

namespace DataLayer.Context
{
	public class MyDbContextBase : DbContext
	{
		private string p;

		public MyDbContextBase()
			: base("MedicallexiconProjectConnectionString")
		{
		}
		public override int SaveChanges()
		{
			try
			{
				return base.SaveChanges();
			}

			catch (DbEntityValidationException validationException)
			{
				throw (NotImplementedException);
			}
			catch (DbUpdateConcurrencyException concurrencyException)
			{
				//بررسی مورد اول
				var dbEntityEntry = concurrencyException.Entries.First();
				var dbPropertyValues = dbEntityEntry.GetDatabaseValues();
				throw (NotImplementedException);
			}
			catch (DbUpdateException updateException)
			{
				if (updateException.InnerException != null)
					Debug.WriteLine(updateException.InnerException.Message);

				foreach (var entry in updateException.Entries)
				{
					Debug.WriteLine(entry.Entity);
				}
				throw (NotImplementedException);
			}

		}

		protected Exception NotImplementedException
		{
			get { throw new NotImplementedException(); }
		}
	}
}