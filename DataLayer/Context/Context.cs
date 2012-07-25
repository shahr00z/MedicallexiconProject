using System;
using System.Data.Entity;
using DataLayer.Mapping;
using DomainClasses.Models;

namespace DataLayer.Context
{
	/// <summary>
	/// این کلاس جهت تشکیل بانک اطلاعاتی درست شده است.
	/// DbSet هر پراپرتی که به صورت 
	/// تعریف شود به ازای آن در دیتا بیس یک جدول می سازد
	///  اضافه شده اندDomainClasses تمامی کلاسها از پروژه  
	/// تنظیمات مربوط به نحوه شکل گیری و همچنین
	/// نیز در این کلاس مشخص خواهد شد Migration مربوط به بحث
	/// </summary>
	public class MedicallexiconContext : MyDbContextBase, IUnitOfWork
	{
		public DbSet<Word> Word { get; set; }
		public DbSet<Category> Category { get; set; }
		public DbSet<Language> Language { get; set; }
		public DbSet<Picture> Picture { get; set; }
		public DbSet<RelationshipBetweenWords> RelationshipBetweenWords { get; set; }
	

		#region IUnitOfWork Members

		/// <summary>
		///  با استفاده از متد 
		/// base.Set 
		///  به سادگي مي‌توان به
		/// DbSetهاي 
		/// مختلف در حين كار با 
		/// IUnitOfWork 
		///  دسترسي پيدا كرد
		/// </summary>
		/// <typeparam name="TEntity"></typeparam>
		/// <returns></returns>

		#region IUnitOfWork Members
		public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
		{
			return base.Set<TEntity>();
		}

		#endregion

		#endregion

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new CategoryConfig());
			modelBuilder.Configurations.Add(new WordConfig());
			modelBuilder.Configurations.Add(new PictureConfig());
			modelBuilder.Configurations.Add(new LanguageConfig());
			modelBuilder.Configurations.Add(new RelationshipBetweenWordsConfig());
			base.OnModelCreating(modelBuilder);
		}
	}
}