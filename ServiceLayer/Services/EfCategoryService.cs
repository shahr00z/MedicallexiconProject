using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using DataLayer.Context;
using DomainClasses.Models;
using ServiceLayer.Interfaces;

namespace ServiceLayer.Services
{
	public class EfCategoryService : ICategoryService
	{
		private readonly IDbSet<Category> _Categorys;
		private readonly IUnitOfWork _uow;

		public EfCategoryService(IUnitOfWork uow)
		{
			_uow = uow;
			_Categorys = _uow.Set<Category>();
		}

		#region ICategoryService Members

		public void AddNew(Category obj)
		{
			obj.UniqID = Guid.NewGuid();
			obj.CreatedDate = DateTime.Now;
			_Categorys.Add(obj);
		}

		public IList<Category> GetAll()
		{
			return (_Categorys.ToList());
		}

		public Category GetByID(int id)
		{
			Category category = _Categorys.Find(id);
			return (category);
		}

		public Category GetByName(string name)
		{
			Category category = _Categorys.FirstOrDefault(x => x.Name == name);
			return (category);
		}

		public void Delete(int id)
		{
			_Categorys.Remove(GetByID(id));
		}

		public void Edit(int id, Category obj)
		{
			throw new NotImplementedException();
		}

		public IList<SelectListItem> GetSelectList()
		{
			return (GetAll().
			Select(x => new SelectListItem
			{
				Text = x.Name,
				Value = x.ID.ToString(CultureInfo.InvariantCulture)
			}).ToList());
		}

		public int GetCount()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}