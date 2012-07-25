using System.Data.Entity;

namespace DataLayer.Context
{
	public  interface IUnitOfWork
	{
		IDbSet<TEntity> Set<TEntity>() where TEntity : class;
		int SaveChanges();
	}
}