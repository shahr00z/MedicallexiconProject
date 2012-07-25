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
	public class EfWordService : IWordService
	{
		private readonly IUnitOfWork _uow;
		private readonly IDbSet<Word> _words;

		public EfWordService(IUnitOfWork uow)
		{
			_uow = uow;
			_words = _uow.Set<Word>();
		}

		#region IWordService Members

		public void AddNew(Word obj)
		{
			obj.UniqID = Guid.NewGuid();
			obj.CreatedDate = DateTime.Now;
			_words.Add(obj);
		}

		public IList<Word> GetAll()
		{
			return (_words.ToList());
		}

		public Word GetByID(int id)
		{

			Word word = _words.Find(id);
			return (word);
		}

		public Word GetByName(string name)
		{
			Word word = _words.FirstOrDefault(x => x.Name == name);
			return (word);
		}

		public void Delete(int id)
		{
			_words.Remove(GetByID(id));
		}

		public void Edit(int id, Word obj)
		{
			throw new NotImplementedException();
		}

		public IList<SelectListItem> GetSelectList()
		{
			return null;
		}

		public IList<Word> GetAllWordByCategory(Category category)
		{
			throw new NotImplementedException();
		}

		public IList<Word> GetAllWordByLanguage(Language language)
		{
			throw new NotImplementedException();
		}

		public int GetCount()
		{
			var count = _words.Count();
			return (count);
		}

		public int GetWordsCountByLanguage(Language language)
		{
			throw new NotImplementedException();
		}

		public int GetWordsCountByCategory(Category category)
		{
			throw new NotImplementedException();
		}

		public IQueryable<Word> Search(string term)
		{


			IQueryable<Word> word = _words
							.Where(r => r.Name.Contains(term) ||
										String.IsNullOrEmpty(term))
							.Take(10);
			return (word);
		}

		public IQueryable<Word> QuickSearch(string term)
		{
			var word = _words
					   .Where(r => r.Name.Contains(term))
					   .Take(10);
			return (word);
		}

		public Word GetWordByWordNameAndLanguageID(string name, int selectedLanguageID)
		{
			Word word = _words.FirstOrDefault(x => x.Name == name & x.LanguageID == selectedLanguageID);
			return (word);
		}

		#endregion
	}
}