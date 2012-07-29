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
	public class EfLanguageService : ILanguageService
	{
		private readonly IDbSet<Language> _Languages;
		private readonly IUnitOfWork _uow;

		public EfLanguageService(IUnitOfWork uow)
		{
			_uow = uow;
			_Languages = _uow.Set<Language>();
		}

		#region ILanguageService Members

		public void AddNew(Language obj)
		{
			obj.UniqID = Guid.NewGuid();
			obj.CreatedDate = DateTime.Now;
			_Languages.Add(obj);
		}

		public IList<Language> GetAll()
		{
			return (_Languages.ToList());
		}

		public Language GetByID(int id)
		{
			Language language = _Languages.Find(id);
			return (language);
		}

		public Language GetByName(string name)
		{
			Language language = _Languages.FirstOrDefault(x => x.Name == name);
			return (language);
		}

		public void Delete(int id)
		{
			_Languages.Remove(GetByID(id));
		}

		public void Edit(int id, Language obj)
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
			int count = _Languages.Count();
			return (count);
		}

		public int GetCountLanguageWithoutWord()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}