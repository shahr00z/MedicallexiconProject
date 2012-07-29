using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Mvc;
using DataLayer.Context;
using DomainClasses.Models;
using ServiceLayer.Interfaces;

namespace ServiceLayer.Services
{
	public class EfRelationshipBetweenWordsService : IRelationshipBetweenWords
	{
		private readonly IDbSet<RelationshipBetweenWords> _relationshipBetweenWords;
		private readonly IUnitOfWork _uow;

		public EfRelationshipBetweenWordsService( IUnitOfWork uow)
		{
			_uow = uow;
			_relationshipBetweenWords = _uow.Set<RelationshipBetweenWords>();
		}

		#region IRelationshipBetweenWords Members

		public void AddNew(RelationshipBetweenWords obj)
		{
			obj.UniqID = Guid.NewGuid();
			obj.CreatedDate = DateTime.Now;
			_relationshipBetweenWords.Add(obj);
		}

		public IList<RelationshipBetweenWords> GetAll()
		{
			throw new NotImplementedException();
		}

		public RelationshipBetweenWords GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public RelationshipBetweenWords GetByName(string name)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public void Edit(int id, RelationshipBetweenWords obj)
		{
			throw new NotImplementedException();
		}

		public IList<SelectListItem> GetSelectList()
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