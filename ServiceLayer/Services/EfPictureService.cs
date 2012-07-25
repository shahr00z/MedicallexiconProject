using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using DataLayer.Context;
using DomainClasses.Models;
using ServiceLayer.Interfaces;

namespace ServiceLayer.Services
{
	public class EfPictureService : IPictureService
	{
		private readonly IDbSet<Picture> _Pictures;
		private readonly IUnitOfWork _uow;

		public EfPictureService(IUnitOfWork uow)
		{
			_uow = uow;
			_Pictures = _uow.Set<Picture>();
		}

		#region IPictureService Members

		public void AddNew(Picture obj)
		{
			obj.UniqID = Guid.NewGuid();
			obj.CreatedDate = DateTime.Now;
			_Pictures.Add(obj);
		}

		public IList<Picture> GetAll()
		{
			return (_Pictures.ToList());
		}

		public Picture GetByID(int id)
		{
			Picture picture = _Pictures.Find(id);
			return (picture);
		}

		public Picture GetByName(string name)
		{
			Picture picture = _Pictures.FirstOrDefault(x => x.Name == name);
			return (picture);
		}

		public void Delete(int id)
		{
			_Pictures.Remove(GetByID(id));
		}

		public void Edit(int id, Picture obj)
		{
			throw new NotImplementedException();
		}

		public IList<SelectListItem> GetSelectList()
		{
			return null;
		}

		public IList<Picture> GetPicturesByTag(string tag)
		{
			throw new NotImplementedException();
		}

		public IList<Picture> GetPicturesByWord(Word word)
		{
			throw new NotImplementedException();
		}

		public IList<Picture> GetPicturesByWordID(Word wordID)
		{
			throw new NotImplementedException();
		}

		public void SavaPictures(IList<Picture> pictures)
		{
			throw new NotImplementedException();
		}

		public int GetCount()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}